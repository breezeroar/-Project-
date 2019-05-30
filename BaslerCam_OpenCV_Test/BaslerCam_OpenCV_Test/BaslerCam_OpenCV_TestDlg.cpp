
// BaslerCam_OpenCV_TestDlg.cpp: 實作檔案
//

#include "stdafx.h"
#include "BaslerCam_OpenCV_Test.h"
#include "BaslerCam_OpenCV_TestDlg.h"
#include "afxdialogex.h"
#include <opencv2/highgui/highgui_c.h>
#include <pylon/PylonGUI.h>
#include <cstdio>
#include <iostream>
using namespace std;

#ifdef _DEBUG
#define new DEBUG_NEW
#endif

void on_mouse(int EVENT, int x, int y, int flags, void* ustc);
cv::Mat OpenCVImage,dst,contour,roiImg, tmpImg, MidImg, angleImg, capImg;
cv::Point drawStart, drawEnd, minLoc;
double minVal;
cv::Rect RoiArea(20, 20, 100, 100);
int choose;
bool matchRoi = false;


// 對 App About 使用 CAboutDlg 對話方塊

class CAboutDlg : public CDialogEx
{
public:
	CAboutDlg();

// 對話方塊資料
#ifdef AFX_DESIGN_TIME
	enum { IDD = IDD_ABOUTBOX };
#endif

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV 支援

// 程式碼實作
protected:
	DECLARE_MESSAGE_MAP()
};

CAboutDlg::CAboutDlg() : CDialogEx(IDD_ABOUTBOX)
{
}

void CAboutDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
}

BEGIN_MESSAGE_MAP(CAboutDlg, CDialogEx)
END_MESSAGE_MAP()


// CBaslerCamOpenCVTestDlg 對話方塊



CBaslerCamOpenCVTestDlg::CBaslerCamOpenCVTestDlg(CWnd* pParent /*=nullptr*/)
	: CDialogEx(IDD_BASLERCAM_OPENCV_TEST_DIALOG, pParent)
{
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}


void CBaslerCamOpenCVTestDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
	//GetDlgItem(IDC_CCD)->MoveWindow(12, 70, 896, 714);
}

BEGIN_MESSAGE_MAP(CBaslerCamOpenCVTestDlg, CDialogEx)
	ON_WM_SYSCOMMAND()
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	ON_STN_CLICKED(IDC_CCD, &CBaslerCamOpenCVTestDlg::OnStnClickedCcd)
	ON_BN_CLICKED(IDC_btn_loadCamera, &CBaslerCamOpenCVTestDlg::OnBnClickedbtnloadcamera)
	ON_BN_CLICKED(IDC_btn_color, &CBaslerCamOpenCVTestDlg::OnBnClickedbtncolor)
	ON_BN_CLICKED(IDC_btn_Gray, &CBaslerCamOpenCVTestDlg::OnBnClickedbtnGray)
	ON_BN_CLICKED(IDC_btn_threshold, &CBaslerCamOpenCVTestDlg::OnBnClickedbtnthreshold)
	ON_BN_CLICKED(IDC_btn_blur, &CBaslerCamOpenCVTestDlg::OnBnClickedbtnblur)
	ON_BN_CLICKED(IDC_btn_sobel, &CBaslerCamOpenCVTestDlg::OnBnClickedbtnsobel)
	ON_BN_CLICKED(IDC_btn_scharr, &CBaslerCamOpenCVTestDlg::OnBnClickedbtnscharr)
	ON_BN_CLICKED(IDC_btn_canny, &CBaslerCamOpenCVTestDlg::OnBnClickedbtncanny)
	ON_BN_CLICKED(IDC_btn_laplacian, &CBaslerCamOpenCVTestDlg::OnBnClickedbtnlaplacian)
	ON_BN_CLICKED(IDC_btn_capture, &CBaslerCamOpenCVTestDlg::OnBnClickedbtncapture)
	ON_BN_CLICKED(IDC_btn_compare, &CBaslerCamOpenCVTestDlg::OnBnClickedbtncompare)
END_MESSAGE_MAP()


// CBaslerCamOpenCVTestDlg 訊息處理常式

UINT CBaslerCamOpenCVTestDlg::CaptureInBackground(LPVOID param)
{
	CBaslerCamOpenCVTestDlg *itemControl = (CBaslerCamOpenCVTestDlg*)param;
	
	Pylon::PylonInitialize();
	Pylon::CInstantCamera cam(Pylon::CTlFactory::GetInstance().CreateFirstDevice());

	cam.Open();

	cam.MaxNumBuffer = 10;

	Pylon::CImageFormatConverter formatConverter;
	formatConverter.OutputPixelFormat = Pylon::PixelType_BGR8packed;
	Pylon::CPylonImage pylonImage;
	
	CHeartbeatHelper heartbeatHelper(cam);
	heartbeatHelper.SetValue(1000);

	cam.StartGrabbing();

	Pylon::CGrabResultPtr ptrGrabResult;
	CRect camRect;
	itemControl->GetDlgItem(IDC_CCD)->GetClientRect(camRect);

	cv::namedWindow("Camera", 0);
	HWND hwnd_Camera = (HWND)cvGetWindowHandle("Camera");
	HWND hparent_Camera = ::GetParent(hwnd_Camera);
	::SetParent(hwnd_Camera, itemControl->GetDlgItem(IDC_CCD)->m_hWnd);
	::ShowWindow(hparent_Camera, SW_HIDE);

	cv::Mat grad_x, grad_y;
	cv::Mat abs_grad_x, abs_grad_y;
	try
	{
		while (cam.IsGrabbing() && choose != 0)
		{
			cam.RetrieveResult(30000, ptrGrabResult, Pylon::TimeoutHandling_ThrowException);
			formatConverter.Convert(pylonImage, ptrGrabResult);
			OpenCVImage = cv::Mat(ptrGrabResult->GetHeight(), ptrGrabResult->GetWidth(), CV_8UC3, (uint8_t *)pylonImage.GetBuffer());
			
			switch (choose)
			{
			case 1:	//Normal
				OpenCVImage.copyTo(MidImg);
				cv::rectangle(MidImg, RoiArea, cv::Scalar(0, 0, 255), 2, 8);

				if (matchRoi == true)
				{
					cv::Mat matchImg;
					matchImg.create(OpenCVImage.rows - capImg.rows + 1, OpenCVImage.cols - capImg.cols + 1, CV_32FC1);

					cv::matchTemplate(OpenCVImage, capImg, matchImg, CV_TM_SQDIFF);
					cv::minMaxLoc(matchImg, &minVal, 0, &minLoc, 0);
					rectangle(MidImg, minLoc, cv::Point(minLoc.x + capImg.cols, minLoc.y + capImg.rows), cv::Scalar(255, 255, 255), 3);
				}
				
				cv::setMouseCallback("Camera", on_mouse, (void*)(&MidImg));
				cv::imshow("Camera", MidImg);
				cv::waitKey(1);
				break;

			case 2:	//Gray
				cv::cvtColor(OpenCVImage, OpenCVImage, CV_BGR2GRAY);
				cv::imshow("Camera", OpenCVImage);
				cv::waitKey(1);
				break;

			case 3:	//Threshold
				cv::threshold(OpenCVImage, OpenCVImage, 150, 255, CV_THRESH_BINARY);
				cv::imshow("Camera", OpenCVImage);
				cv::waitKey(1);
				break;

			case 4:	//Blur
				cv::blur(OpenCVImage, OpenCVImage, cv::Size(5, 5));
				cv::imshow("Camera", OpenCVImage);
				cv::waitKey(1);
				break;

			case 5:	//Sobel
				cv::Sobel(OpenCVImage, grad_x, CV_16S, 1, 0, 3, 1, 0, cv::BORDER_DEFAULT);
				cv::convertScaleAbs(grad_x, abs_grad_x);  //轉成CV_8U
				cv::Sobel(OpenCVImage, grad_y, CV_16S, 0, 1, 3, 1, 0, cv::BORDER_DEFAULT);
				cv::convertScaleAbs(grad_y, abs_grad_y);

				cv::addWeighted(abs_grad_x, 0.5, abs_grad_y, 0.5, 0, dst);
				cv::imshow("Camera", dst);
				cv::waitKey(1);
				break;

			case 6:	//Scharr
				cv::Scharr(OpenCVImage, grad_x, CV_16S, 1, 0, 1, 0, cv::BORDER_DEFAULT);
				cv::convertScaleAbs(grad_x, abs_grad_x);  //轉成CV_8U
				cv::Scharr(OpenCVImage, grad_y, CV_16S, 0, 1, 1, 0, cv::BORDER_DEFAULT);
				cv::convertScaleAbs(grad_y, abs_grad_y);

				addWeighted(abs_grad_x, 0.5, abs_grad_y, 0.5, 0, dst);
				cv::imshow("Camera", dst);
				cv::waitKey(1);
				break;

			case 7:	//Canny
				cv::GaussianBlur(OpenCVImage, OpenCVImage, cv::Size(3, 3), 0, 0);
				cv::Canny(OpenCVImage, dst, 50, 150, 3);
				cv::imshow("Camera", dst);
				cv::waitKey(1);
				break;

			case 8:	//Laplacian
				cv::Laplacian(OpenCVImage, dst, CV_16S, 3, 1, 0, cv::BORDER_DEFAULT);
				cv::convertScaleAbs(dst, dst);
				cv::imshow("Camera", dst);
				cv::waitKey(1);
				break;
			}
		}
	}
	catch (...)
	{
		itemControl->GetDlgItem(IDC_btn_loadCamera)->EnableWindow(TRUE);
		cv::destroyWindow("Camera");
		itemControl->MessageBox(_T("cccc"));

	}
	return 0;
}

BOOL CBaslerCamOpenCVTestDlg::OnInitDialog()
{
	CDialogEx::OnInitDialog();

	// 將 [關於...] 功能表加入系統功能表。

	// IDM_ABOUTBOX 必須在系統命令範圍之中。
	ASSERT((IDM_ABOUTBOX & 0xFFF0) == IDM_ABOUTBOX);
	ASSERT(IDM_ABOUTBOX < 0xF000);

	CMenu* pSysMenu = GetSystemMenu(FALSE);
	if (pSysMenu != nullptr)
	{
		BOOL bNameValid;
		CString strAboutMenu;
		bNameValid = strAboutMenu.LoadString(IDS_ABOUTBOX);
		ASSERT(bNameValid);
		if (!strAboutMenu.IsEmpty())
		{
			pSysMenu->AppendMenu(MF_SEPARATOR);
			pSysMenu->AppendMenu(MF_STRING, IDM_ABOUTBOX, strAboutMenu);
		}
	}

	// 設定此對話方塊的圖示。當應用程式的主視窗不是對話方塊時，
	// 框架會自動從事此作業
	SetIcon(m_hIcon, TRUE);			// 設定大圖示
	SetIcon(m_hIcon, FALSE);		// 設定小圖示

	// TODO: 在此加入額外的初始設定

	return TRUE;  // 傳回 TRUE，除非您對控制項設定焦點
}

void CBaslerCamOpenCVTestDlg::OnSysCommand(UINT nID, LPARAM lParam)
{
	if ((nID & 0xFFF0) == IDM_ABOUTBOX)
	{
		CAboutDlg dlgAbout;
		dlgAbout.DoModal();
	}
	else
	{
		CDialogEx::OnSysCommand(nID, lParam);
	}
}

// 如果將最小化按鈕加入您的對話方塊，您需要下列的程式碼，
// 以便繪製圖示。對於使用文件/檢視模式的 MFC 應用程式，
// 框架會自動完成此作業。

void CBaslerCamOpenCVTestDlg::OnPaint()
{
	if (IsIconic())
	{
		CPaintDC dc(this); // 繪製的裝置內容

		SendMessage(WM_ICONERASEBKGND, reinterpret_cast<WPARAM>(dc.GetSafeHdc()), 0);

		// 將圖示置中於用戶端矩形
		int cxIcon = GetSystemMetrics(SM_CXICON);
		int cyIcon = GetSystemMetrics(SM_CYICON);
		CRect rect;
		GetClientRect(&rect);
		int x = (rect.Width() - cxIcon + 1) / 2;
		int y = (rect.Height() - cyIcon + 1) / 2;

		// 描繪圖示
		dc.DrawIcon(x, y, m_hIcon);
	}
	else
	{
		CDialogEx::OnPaint();
	}
}

// 當使用者拖曳最小化視窗時，
// 系統呼叫這個功能取得游標顯示。
HCURSOR CBaslerCamOpenCVTestDlg::OnQueryDragIcon()
{
	return static_cast<HCURSOR>(m_hIcon);
}

void CBaslerCamOpenCVTestDlg::OnTcnSelchangeTab1(NMHDR *pNMHDR, LRESULT *pResult)
{
	// TODO: 在此加入控制項告知處理常式程式碼
	*pResult = 0;
}

void CBaslerCamOpenCVTestDlg::OnStnClickedCcd()
{
	// TODO: 在此加入控制項告知處理常式程式碼
}



void CBaslerCamOpenCVTestDlg::OnBnClickedbtnloadcamera()
{
	// TODO: 在此加入控制項告知處理常式程式碼
	GetDlgItem(IDC_btn_loadCamera)->EnableWindow(FALSE);
	GetDlgItem(IDC_btn_color)->EnableWindow(TRUE);
	GetDlgItem(IDC_btn_Gray)->EnableWindow(TRUE);
	GetDlgItem(IDC_btn_threshold)->EnableWindow(TRUE);
	GetDlgItem(IDC_btn_blur)->EnableWindow(TRUE);
	GetDlgItem(IDC_btn_canny)->EnableWindow(TRUE);
	GetDlgItem(IDC_btn_laplacian)->EnableWindow(TRUE);
	GetDlgItem(IDC_btn_sobel)->EnableWindow(TRUE);
	GetDlgItem(IDC_btn_scharr)->EnableWindow(TRUE);
	GetDlgItem(IDC_btn_capture)->EnableWindow(TRUE);
	GetDlgItem(IDC_btn_compare)->EnableWindow(TRUE);
	choose = 1;
	AfxBeginThread(CaptureInBackground, (LPVOID)this, THREAD_PRIORITY_ABOVE_NORMAL);
}

void CBaslerCamOpenCVTestDlg::OnBnClickedbtncolor()
{
	// TODO: 在此加入控制項告知處理常式程式碼
	choose = 1;
}

void CBaslerCamOpenCVTestDlg::OnBnClickedbtnGray()
{
	choose = 2;
	// TODO: 在此加入控制項告知處理常式程式碼
}

void CBaslerCamOpenCVTestDlg::OnBnClickedbtnthreshold()
{
	choose = 3;
	// TODO: 在此加入控制項告知處理常式程式碼
}

void CBaslerCamOpenCVTestDlg::OnBnClickedbtnblur()
{
	// TODO: 在此加入控制項告知處理常式程式碼
	choose = 4;
}

void CBaslerCamOpenCVTestDlg::OnBnClickedbtnsobel()
{
	// TODO: 在此加入控制項告知處理常式程式碼
	choose = 5;
}

void CBaslerCamOpenCVTestDlg::OnBnClickedbtnscharr()
{
	// TODO: 在此加入控制項告知處理常式程式碼
	choose = 6;
}

void CBaslerCamOpenCVTestDlg::OnBnClickedbtncanny()
{
	// TODO: 在此加入控制項告知處理常式程式碼
	choose = 7;
}

void CBaslerCamOpenCVTestDlg::OnBnClickedbtnlaplacian()
{
	// TODO: 在此加入控制項告知處理常式程式碼
	choose = 8;
}

void on_mouse(int EVENT, int x, int y, int flags, void* ustc)
{
	static cv::Point start_PT;

	if (EVENT == CV_EVENT_LBUTTONDOWN || EVENT == CV_EVENT_RBUTTONDOWN)
	{
		cv::Point cur = cv::Point(x, y);

		if (RoiArea.contains(cur))
		{
			start_PT = cur;
		}
	}

	if (EVENT == CV_EVENT_MOUSEMOVE && flags == CV_EVENT_FLAG_RBUTTON)
	{
		cv::Point cur = cv::Point(x, y);

		if (RoiArea.contains(cur))
		{
			SetCursor(LoadCursor(NULL, IDC_SIZENWSE));
			OpenCVImage.copyTo(MidImg);
			RoiArea = RoiArea + cv::Size(cur.x - start_PT.x, cur.y - start_PT.y);
			rectangle(MidImg, RoiArea, cv::Scalar(0, 0, 255), 2, 8);
			start_PT = cur;
			imshow("Camera", MidImg);
		}
	}

	if (EVENT == CV_EVENT_MOUSEMOVE && flags == CV_EVENT_FLAG_LBUTTON)
	{
		cv::Point cur = cv::Point(x, y);

		if (RoiArea.contains(cur))
		{
			SetCursor(LoadCursor(NULL, IDC_SIZEALL));
			OpenCVImage.copyTo(MidImg);
			RoiArea = RoiArea + cv::Point(cur.x - start_PT.x, cur.y - start_PT.y);
			rectangle(MidImg, RoiArea, cv::Scalar(0, 0, 255), 2, 8);
			start_PT = cur;
			imshow("Camera", MidImg);
		}
	}

	if (EVENT == CV_EVENT_LBUTTONUP || EVENT == CV_EVENT_RBUTTONUP)
	{
		rectangle(MidImg, RoiArea, cv::Scalar(0, 0, 255), 2, 8);
		imshow("Camera", MidImg);
		start_PT = cv::Point(-1, -1);
	}
}

void CBaslerCamOpenCVTestDlg::OnBnClickedbtncapture()
{
	try
	{
		OpenCVImage.copyTo(roiImg);
		capImg = roiImg(RoiArea);
		cv::namedWindow("showRoi");

		cv::Mat edge;
		cvtColor(capImg, edge, CV_BGR2GRAY);
		cv::blur(edge, edge, cv::Size(3, 3));
		cv::adaptiveThreshold(edge, edge, 255, CV_ADAPTIVE_THRESH_GAUSSIAN_C, CV_THRESH_BINARY, 65, 0);
		//imshow("showThreshold", edge);
		cv::Canny(edge, edge, 0, 150, 3);

		vector<vector<cv::Point>> contours(1000);
		vector<cv::Vec4i> hierarchy(1000);
		findContours(edge, contours, hierarchy, CV_RETR_EXTERNAL, CV_CHAIN_APPROX_SIMPLE);
		int catchArea = NULL;
		double largestArea = 0;
		for (int i = 1; i < contours.size(); i++)
		{
			double a = contourArea(contours[i], false);
			if (a > largestArea)
			{
				largestArea = a;
				catchArea = i;
			}
		}
		cv::Scalar color = (0, 255, 255);
		drawContours(capImg, contours, catchArea, color, 2, CV_AA, hierarchy);

		cv::Moments M = moments(contours[catchArea]);
		cv::Point2f center = cv::Point2d(M.m10 / M.m00, M.m01 / M.m00);
		circle(capImg, center, 3, cv::Scalar(0, 0, 255), CV_FILLED, 8);

		//imshow("showCanny", edge);
		imshow("showRoi", capImg);
	}
	catch (...)
	{
		MessageBox(_T("cc"));
	}
}

void CBaslerCamOpenCVTestDlg::OnBnClickedbtncompare()
{
	matchRoi = true;
}
