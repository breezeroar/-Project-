// Pomeas DualDlg.h : header file
//

#pragma once
#include "afxwin.h"
#include "MyButton.h"


// CPomeasDualDlg dialog
class CPomeasDualDlg : public CDialog
{
// Construction
public:
	CPomeasDualDlg(CWnd* pParent = NULL);	// standard constructor

// Dialog Data
	enum { IDD = IDD_POMEASDUAL_DIALOG };

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV support


// Implementation
protected:
	HICON m_hIcon;

	// Generated message map functions
	virtual BOOL OnInitDialog();
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	DECLARE_MESSAGE_MAP()
public:
	int m_CommIndex;
public:
	CComboBox m_PortsComBox;
public:
	afx_msg void OnCbnSelchangePortscombox();
public:
	afx_msg void OnBnClickedCancel();
public:
	afx_msg void OnBnClickedHome();
public:
	afx_msg void OnBnClickedLimit();
public:
	afx_msg void OnBnClickedReset();
public:
	afx_msg void OnBnClickedStop();
public:
	afx_msg void OnBnClickedUp();
public:
	afx_msg void OnBnClickedDown();
public:
	afx_msg void OnBnClickedDestination();
public:
	CXPButton m_HomeBtn;
public:
	CXPButton m_LimitBtn;
public:
	CXPButton m_ResetBtn;
public:
	CXPButton m_StopBtn;
public:
	CMoveUpButton m_UpBtn;
public:
	CMoveDownButton m_DownBtn;
public:
	CXPButton m_DestinationBtn;
public:
	CXPButton m_ExitBtn;
public:
	long m_Destination;
public:
	CXPButton m_AutoMoveBtn;
public:
	afx_msg void OnBnClickedAutorun();
public:
	afx_msg void OnBnClickedSave1();
public:
	afx_msg void OnBnClickedSave2();
public:
	afx_msg void OnBnClickedSave3();
public:
	afx_msg void OnBnClickedSave4();
public:
	afx_msg void OnBnClickedSave5();
public:
	afx_msg void OnBnClickedSave6();
public:
	afx_msg void OnBnClickedSave7();
public:
	afx_msg void OnBnClickedSave8();
public:
	afx_msg void OnBnClickedSave9();
public:
	afx_msg void OnBnClickedSave10();
public:
	afx_msg void OnBnClickedSelectgoto1();
public:
	afx_msg void OnBnClickedSelectgoto2();
public:
	afx_msg void OnBnClickedSelectgoto3();
public:
	afx_msg void OnBnClickedSelectgoto4();
public:
	afx_msg void OnBnClickedSelectgoto5();
public:
	afx_msg void OnBnClickedSelectgoto6();
public:
	afx_msg void OnBnClickedSelectgoto7();
public:
	afx_msg void OnBnClickedSelectgoto8();
public:
	afx_msg void OnBnClickedSelectgoto9();
public:
	afx_msg void OnBnClickedSelectgoto10();
public:
	afx_msg void OnBnClickedGoto1();
public:
	afx_msg void OnBnClickedGoto2();
public:
	afx_msg void OnBnClickedGoto3();
public:
	afx_msg void OnBnClickedGoto4();
public:
	afx_msg void OnBnClickedGoto5();
public:
	afx_msg void OnBnClickedGoto6();
public:
	afx_msg void OnBnClickedGoto7();
public:
	afx_msg void OnBnClickedGoto8();
public:
	afx_msg void OnBnClickedGoto9();
public:
	afx_msg void OnBnClickedGoto10();
public:
	CXPButton m_Save1Btn;
public:
	CXPButton m_Save2Btn;
public:
	CXPButton m_Save3Btn;
public:
	CXPButton m_Save4Btn;
public:
	CXPButton m_Save5Btn;
public:
	CXPButton m_Save6Btn;
public:
	CXPButton m_Save7Btn;
public:
	CXPButton m_Save8Btn;
public:
	CXPButton m_Save9Btn;
public:
	CXPButton m_Save10Btn;
public:
	CButton m_Select1Btn;
public:
	CButton m_Select2Btn;
public:
	CButton m_Select3Btn;
public:
	CButton m_Select4Btn;
public:
	CButton m_Select5Btn;
public:
	CButton m_Select6Btn;
public:
	CButton m_Select7Btn;
public:
	CButton m_Select8Btn;
public:
	CButton m_Select9Btn;
public:
	CButton m_Select10Btn;
public:
	CXPButton m_Goto1Btn;
public:
	CXPButton m_Goto2Btn;
public:
	CXPButton m_Goto3Btn;
public:
	CXPButton m_Goto4Btn;
public:
	CXPButton m_Goto5Btn;
public:
	CXPButton m_Goto6Btn;
public:
	CXPButton m_Goto7Btn;
public:
	CXPButton m_Goto8Btn;
public:
	CXPButton m_Goto9Btn;
public:
	CXPButton m_Goto10Btn;
public:
	afx_msg void OnBnClickedReadstate();
public:
	afx_msg void OnBnClickedStopreadstate();
public:
	CXPButton m_GetStateBtn;
public:
	CXPButton m_StopGetStateBtn;
public:
	CStatic m_StateControl;
public:
	long m_Port1;
	long m_Port2;
	long m_Port3;
	long m_Port4;
	long m_Port5;
	long m_Port6;
	long m_Port7;
	long m_Port8;
	long m_Port9;
	long m_Port10;

	bool m_bMoveTo1;
	bool m_bMoveTo2;
	bool m_bMoveTo3;
	bool m_bMoveTo4;
	bool m_bMoveTo5;
	bool m_bMoveTo6;
	bool m_bMoveTo7;
	bool m_bMoveTo8;
	bool m_bMoveTo9;
	bool m_bMoveTo10;
public:
	afx_msg void OnBnClickedStopautorun();
public:
	CXPButton m_StopAutoMoveBtn;
public:
	afx_msg void OnTimer(UINT_PTR nIDEvent);
public:
	static UINT AutoMoveThread(LPVOID lParam);
	bool m_bStopAutoMove;
public:
	CBrush m_Brush;

	afx_msg HBRUSH OnCtlColor(CDC* pDC, CWnd* pWnd, UINT nCtlColor);
public:
	afx_msg void OnBnClickedOpensavebtn();
public:
	afx_msg void OnBnClickedClosesavebtn();
public:
	CXPButton m_OpenSaveBtn;
public:
	CXPButton m_CloseSaveBtn;
public:
	int m_AutoRunIndex;
	int m_AutoRunStep;
	int m_AutoRunCount;
public:
	int m_SleepTimer;
public:
	afx_msg void OnBnClickedGetmaxlength();
public:
	CStatic m_maxLengthStatic;
public:
	CStatic m_MotionStateControl;
};
