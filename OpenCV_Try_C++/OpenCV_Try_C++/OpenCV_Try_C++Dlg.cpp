
// OpenCV_Try_C++Dlg.cpp: 實作檔案
//

#include "stdafx.h"
#include "OpenCV_Try_C++.h"
#include "OpenCV_Try_C++Dlg.h"
#include "afxdialogex.h"
#include <opencv2/highgui/highgui_c.h>
#include <opencv.hpp>
#include<iostream>
using namespace cv;
using namespace std;

void on_mouse(int EVENT, int x, int y, int flags, void* ustc);

#ifdef _DEBUG
#define new DEBUG_NEW
#endif

Mat srcImg,tmpImg,MidImg,roiImg,capImg;
Rect RoiArea(100, 100, 300, 300);
bool sizeFlag = false;

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


// COpenCVTryCDlg 對話方塊



COpenCVTryCDlg::COpenCVTryCDlg(CWnd* pParent /*=nullptr*/)
	: CDialogEx(IDD_OPENCV_TRY_C_DIALOG, pParent)
{
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

void COpenCVTryCDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
}

BEGIN_MESSAGE_MAP(COpenCVTryCDlg, CDialogEx)
	ON_WM_SYSCOMMAND()
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
//	ON_STN_CLICKED(IDC_PIC, &COpenCVTryCDlg::OnStnClickedPic)
ON_STN_CLICKED(IDC_PIC, &COpenCVTryCDlg::OnStnClickedPic)
ON_BN_CLICKED(IDC_MFCBUTTON, &COpenCVTryCDlg::OnBnClickedMfcbutton1)
ON_BN_CLICKED(IDC_MFCBUTTONCAPTURE, &COpenCVTryCDlg::OnBnClickedMfcbuttoncapture)
END_MESSAGE_MAP()


// COpenCVTryCDlg 訊息處理常式

BOOL COpenCVTryCDlg::OnInitDialog()
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

void COpenCVTryCDlg::OnSysCommand(UINT nID, LPARAM lParam)
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

void COpenCVTryCDlg::OnPaint()
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
HCURSOR COpenCVTryCDlg::OnQueryDragIcon()
{
	return static_cast<HCURSOR>(m_hIcon);
}


void COpenCVTryCDlg::OnStnClickedPic()
{
	// TODO: 在此加入控制項告知處理常式程式碼
}


void COpenCVTryCDlg::OnBnClickedMfcbutton1()
{
	namedWindow("showImage", 0);
	HWND hWnd_showImage = (HWND)cvGetWindowHandle("showImage");
	HWND hParent_showImage = ::GetParent(hWnd_showImage);
	::SetParent(hWnd_showImage, GetDlgItem(IDC_PIC)->m_hWnd);
	::ShowWindow(hParent_showImage, SW_HIDE);
	try
	{

		srcImg = imread("abc.jpg");
		srcImg.copyTo(tmpImg);
		rectangle(tmpImg,RoiArea,Scalar(0,0,255),3,8 );
		imshow("showImage", tmpImg);
		setMouseCallback("showImage", on_mouse, (void*)(&tmpImg)); //呼叫回撥函式 
		waitKey(1);
	}
	catch (...)
	{
		MessageBox(_T("cc"));
		::DestroyWindow(hParent_showImage);
	}
	// TODO: 在此加入控制項告知處理常式程式碼
}

void COpenCVTryCDlg::OnBnClickedMfcbuttoncapture()
{
	srcImg.copyTo(roiImg);
	capImg = roiImg(RoiArea);
	namedWindow("showRoi");

	Mat edge;
	cvtColor(capImg, edge, CV_BGR2GRAY);
	blur(edge, edge, Size(3, 3));
	threshold(edge, edge, 150, 255, THRESH_BINARY);
	Canny(edge, edge, 0, 150, 3);

	vector<vector<Point>> contours;
	vector<Vec4i> hierarchy;
	findContours(edge, contours, hierarchy, CV_RETR_TREE, CV_CHAIN_APPROX_SIMPLE);
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
	Scalar color = (0, 255, 255);
	drawContours(capImg, contours, catchArea, color, 2, 8, hierarchy);

	Moments M = moments(contours[catchArea]);
	Point2f center = Point2f(M.m10 / M.m00, M.m01 / M.m00);
	circle(capImg, center, 3, Scalar(0,0,255), CV_FILLED, 8);

	imshow("showCanny", edge);
	imshow("showRoi", capImg);
}

void on_mouse(int EVENT, int x, int y, int flags, void* ustc)
{
	static Point start_PT;

	if (EVENT == CV_EVENT_LBUTTONDOWN)
	{
		Point cur = Point(x, y);

		if (RoiArea.contains(cur))
		{
			start_PT = cur;
		}
	}

	if (EVENT == CV_EVENT_RBUTTONDOWN)
	{
		if (sizeFlag == false)
		{
			sizeFlag = true;
		}
		else
		{
			sizeFlag = false;
		}
	}

	if (EVENT == CV_EVENT_MOUSEMOVE)
	{
			if (sizeFlag == false)
			{
				SetCursor(LoadCursor(NULL, IDC_SIZEALL));
			}
			else if (sizeFlag == true)
			{
				SetCursor(LoadCursor(NULL, IDC_SIZENWSE));
			}
	}
	if (EVENT == CV_EVENT_MOUSEMOVE && flags == CV_EVENT_FLAG_LBUTTON)
	{
		Point cur = Point(x, y);

		if (RoiArea.contains(cur))
		{
			if (sizeFlag == false)
			{
				srcImg.copyTo(MidImg);
				RoiArea = RoiArea + Point(cur.x - start_PT.x, cur.y - start_PT.y);
				rectangle(MidImg, RoiArea, Scalar(0, 255, 0), 3, 8);
				start_PT = cur;
				imshow("showImage", MidImg);
			}
			else if (sizeFlag == true)
			{
				srcImg.copyTo(MidImg);
				RoiArea = RoiArea + Size(cur.x - start_PT.x, cur.y - start_PT.y);
				rectangle(MidImg, RoiArea, Scalar(0, 255, 0), 3, 8);
				start_PT = cur;
				imshow("showImage", MidImg);
			}
		}
	}
	if (EVENT == CV_EVENT_LBUTTONUP)
	{
		rectangle(MidImg, RoiArea, Scalar(0, 255, 255), 3, 8);
		imshow("showImage", MidImg);
		start_PT = Point(-1, -1);
	}
}

