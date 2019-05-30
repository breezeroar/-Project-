
// BaslerCam_OpenCV_TestDlg.h: 標頭檔
//

#pragma once
#include <opencv2/opencv.hpp>
#include <pylon/PylonIncludes.h>


// CBaslerCamOpenCVTestDlg 對話方塊
class CBaslerCamOpenCVTestDlg : public CDialogEx
{
// 建構
public:
	CBaslerCamOpenCVTestDlg(CWnd* pParent = nullptr);	// 標準建構函式

// 對話方塊資料
#ifdef AFX_DESIGN_TIME
	enum { IDD = IDD_BASLERCAM_OPENCV_TEST_DIALOG };
#endif

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV 支援


// 程式碼實作
protected:
	HICON m_hIcon;

	// 產生的訊息對應函式
	virtual BOOL OnInitDialog();
	afx_msg void OnSysCommand(UINT nID, LPARAM lParam);
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	DECLARE_MESSAGE_MAP()
public:
	afx_msg void OnTcnSelchangeTab1(NMHDR *pNMHDR, LRESULT *pResult);
	afx_msg void OnStnClickedCcd();
	afx_msg void OnBnClickedbtnloadcamera();
	afx_msg void OnBnClickedbtncolor();
	afx_msg void OnBnClickedbtnGray();
	afx_msg void OnBnClickedbtnthreshold();
	afx_msg void OnBnClickedbtnblur();
	UINT static CaptureInBackground(LPVOID param);
	afx_msg void OnBnClickedbtnsobel();
	afx_msg void OnBnClickedbtnscharr();
	afx_msg void OnBnClickedbtncanny();
	afx_msg void OnBnClickedbtnlaplacian();
	afx_msg void OnBnClickedbtncapture();
	afx_msg void OnBnClickedbtncompare();
};

class CHeartbeatHelper
{
public:
	explicit CHeartbeatHelper(Pylon::CInstantCamera& camera)
		: m_pHeartbeatTimeout(NULL)
	{
		// m_pHeartbeatTimeout may be NULL
		m_pHeartbeatTimeout = camera.GetTLNodeMap().GetNode("HeartbeatTimeout");
	}

	bool SetValue(int64_t NewValue)
	{
		// Do nothing if no heartbeat feature is available.
		if (!m_pHeartbeatTimeout.IsValid())
			return false;

		// Apply the increment and cut off invalid values if neccessary.
		int64_t correctedValue = NewValue - (NewValue % m_pHeartbeatTimeout->GetInc());

		m_pHeartbeatTimeout->SetValue(correctedValue);
		return true;
	}

	bool SetMax()
	{
		// Do nothing if no heartbeat feature is available.
		if (!m_pHeartbeatTimeout.IsValid())
			return false;

		int64_t maxVal = m_pHeartbeatTimeout->GetMax();
		return SetValue(maxVal);
	}

protected:
	GenApi::CIntegerPtr m_pHeartbeatTimeout; // Pointer to the node, will be NULL if no node exists.
};
