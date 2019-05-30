
// OpenCV_Try_C++Dlg.h: 標頭檔
//

#pragma once


// COpenCVTryCDlg 對話方塊
class COpenCVTryCDlg : public CDialogEx
{
// 建構
public:
	COpenCVTryCDlg(CWnd* pParent = nullptr);	// 標準建構函式

// 對話方塊資料
#ifdef AFX_DESIGN_TIME
	enum { IDD = IDD_OPENCV_TRY_C_DIALOG };
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
//	afx_msg void OnStnClickedPic();
	afx_msg void OnStnClickedPic();
	afx_msg void OnBnClickedMfcbutton1();
	afx_msg void OnBnClickedMfcbuttoncapture();
};
