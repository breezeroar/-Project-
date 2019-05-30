// Pomeas DualDlg.cpp : implementation file
//

#include "stdafx.h"
#include "Pomeas Dual.h"
#include "Pomeas DualDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif


// CPomeasDualDlg dialog




CPomeasDualDlg::CPomeasDualDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CPomeasDualDlg::IDD, pParent)
	, m_Destination(0)
	, m_SleepTimer(0)
{
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);

	//////////////////////////////////////////////////////////////////////////////////////////////////////////////
	//系统参数
	CFileStatus statussystem;
	if(CFile::GetStatus((CString)GetAppPath()+"System.dat",statussystem))
	{
		CFile filesystem((CString)GetAppPath()+"System.dat", CFile::modeRead);
		CArchive arsystem(&filesystem, CArchive::store|CArchive::bNoFlushOnDelete|CArchive::load );

		arsystem >>m_CommIndex;
		arsystem >>m_Port1 >>m_Port2 >>m_Port3 >>m_Port4 >>m_Port5 >>m_Port6 >>m_Port7 >>m_Port8 >>m_Port9 >>m_Port10;
		arsystem >>m_bMoveTo1 >>m_bMoveTo2 >>m_bMoveTo3 >>m_bMoveTo4 >>m_bMoveTo5 >>m_bMoveTo6 >>m_bMoveTo7 >>m_bMoveTo8 >>m_bMoveTo9 >>m_bMoveTo10;
		arsystem >>m_SleepTimer >>m_AutoRunCount;

		arsystem.Flush();
		arsystem.Close();
		filesystem.Close();
	}
	else
	{
		m_CommIndex = 0;

		m_Port1=0;
		m_Port2=2000;
		m_Port3=4000;
		m_Port4=6000;
		m_Port5=8000;
		m_Port6=10000;
		m_Port7=12000;
		m_Port8=14000;
		m_Port9=16000;
		m_Port10=18000;

		m_bMoveTo1=FALSE;
		m_bMoveTo2=FALSE;
		m_bMoveTo3=FALSE;
		m_bMoveTo4=FALSE;
		m_bMoveTo5=FALSE;
		m_bMoveTo6=FALSE;
		m_bMoveTo7=FALSE;
		m_bMoveTo8=FALSE;
		m_bMoveTo9=FALSE;
		m_bMoveTo10=FALSE;

		m_SleepTimer=1000;
		m_AutoRunCount=1;
	}
	//////////////////////////////////////////////////////////////////////////////////////////////////////////////

	m_AutoRunIndex=0;
	m_AutoRunStep=1;

	m_Brush.CreateSolidBrush(RGB(0,200,0));
}

void CPomeasDualDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	DDX_Control(pDX, IDC_PORTSCOMBOX, m_PortsComBox);
	DDX_Control(pDX, IDC_HOME, m_HomeBtn);
	DDX_Control(pDX, IDC_LIMIT, m_LimitBtn);
	DDX_Control(pDX, IDC_RESET, m_ResetBtn);
	DDX_Control(pDX, IDC_STOP, m_StopBtn);
	DDX_Control(pDX, IDC_UP, m_UpBtn);
	DDX_Control(pDX, IDC_DOWN, m_DownBtn);
	DDX_Control(pDX, IDC_DESTINATION, m_DestinationBtn);
	DDX_Control(pDX, IDCANCEL, m_ExitBtn);
	DDX_Text(pDX, IDC_DESTINATIONEDIT, m_Destination);
	DDX_Control(pDX, IDC_AUTORUN, m_AutoMoveBtn);
	DDX_Control(pDX, IDC_Save1, m_Save1Btn);
	DDX_Control(pDX, IDC_Save2, m_Save2Btn);
	DDX_Control(pDX, IDC_Save3, m_Save3Btn);
	DDX_Control(pDX, IDC_Save4, m_Save4Btn);
	DDX_Control(pDX, IDC_Save5, m_Save5Btn);
	DDX_Control(pDX, IDC_Save6, m_Save6Btn);
	DDX_Control(pDX, IDC_Save7, m_Save7Btn);
	DDX_Control(pDX, IDC_Save8, m_Save8Btn);
	DDX_Control(pDX, IDC_Save9, m_Save9Btn);
	DDX_Control(pDX, IDC_Save10, m_Save10Btn);
	DDX_Control(pDX, IDC_SELECTGOTO1, m_Select1Btn);
	DDX_Control(pDX, IDC_SELECTGOTO2, m_Select2Btn);
	DDX_Control(pDX, IDC_SELECTGOTO3, m_Select3Btn);
	DDX_Control(pDX, IDC_SELECTGOTO4, m_Select4Btn);
	DDX_Control(pDX, IDC_SELECTGOTO5, m_Select5Btn);
	DDX_Control(pDX, IDC_SELECTGOTO6, m_Select6Btn);
	DDX_Control(pDX, IDC_SELECTGOTO7, m_Select7Btn);
	DDX_Control(pDX, IDC_SELECTGOTO8, m_Select8Btn);
	DDX_Control(pDX, IDC_SELECTGOTO9, m_Select9Btn);
	DDX_Control(pDX, IDC_SELECTGOTO10, m_Select10Btn);
	DDX_Control(pDX, IDC_Goto1, m_Goto1Btn);
	DDX_Control(pDX, IDC_Goto2, m_Goto2Btn);
	DDX_Control(pDX, IDC_Goto3, m_Goto3Btn);
	DDX_Control(pDX, IDC_Goto4, m_Goto4Btn);
	DDX_Control(pDX, IDC_Goto5, m_Goto5Btn);
	DDX_Control(pDX, IDC_Goto6, m_Goto6Btn);
	DDX_Control(pDX, IDC_Goto7, m_Goto7Btn);
	DDX_Control(pDX, IDC_Goto8, m_Goto8Btn);
	DDX_Control(pDX, IDC_Goto9, m_Goto9Btn);
	DDX_Control(pDX, IDC_Goto10, m_Goto10Btn);
	DDX_Control(pDX, IDC_READSTATE, m_GetStateBtn);
	DDX_Control(pDX, IDC_STOPREADSTATE, m_StopGetStateBtn);
	DDX_Control(pDX, IDC_STATE, m_StateControl);
	DDX_Control(pDX, IDC_STOPAUTORUN, m_StopAutoMoveBtn);
	DDX_Control(pDX, IDC_OPENSAVEBTN, m_OpenSaveBtn);
	DDX_Control(pDX, IDC_CLOSESAVEBTN, m_CloseSaveBtn);
	DDX_Text(pDX, IDC_AUTORUNCOUNT, m_AutoRunCount);
	DDV_MinMaxInt(pDX, m_AutoRunCount, 1, 1000000);
	DDX_Text(pDX, IDC_AUTORUNCOUNT2, m_SleepTimer);
	DDV_MinMaxInt(pDX, m_SleepTimer, 100, 10000);
	DDX_Control(pDX, IDC_STATE2, m_maxLengthStatic);
	DDX_Control(pDX, IDC_MOTIONSTATE, m_MotionStateControl);
}

BEGIN_MESSAGE_MAP(CPomeasDualDlg, CDialog)
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	//}}AFX_MSG_MAP
	ON_CBN_SELCHANGE(IDC_PORTSCOMBOX, &CPomeasDualDlg::OnCbnSelchangePortscombox)
	ON_BN_CLICKED(IDCANCEL, &CPomeasDualDlg::OnBnClickedCancel)
	ON_BN_CLICKED(IDC_HOME, &CPomeasDualDlg::OnBnClickedHome)
	ON_BN_CLICKED(IDC_LIMIT, &CPomeasDualDlg::OnBnClickedLimit)
	ON_BN_CLICKED(IDC_RESET, &CPomeasDualDlg::OnBnClickedReset)
	ON_BN_CLICKED(IDC_STOP, &CPomeasDualDlg::OnBnClickedStop)
	ON_BN_CLICKED(IDC_UP, &CPomeasDualDlg::OnBnClickedUp)
	ON_BN_CLICKED(IDC_DOWN, &CPomeasDualDlg::OnBnClickedDown)
	ON_BN_CLICKED(IDC_DESTINATION, &CPomeasDualDlg::OnBnClickedDestination)
	ON_BN_CLICKED(IDC_AUTORUN, &CPomeasDualDlg::OnBnClickedAutorun)
	ON_BN_CLICKED(IDC_Save1, &CPomeasDualDlg::OnBnClickedSave1)
	ON_BN_CLICKED(IDC_Save2, &CPomeasDualDlg::OnBnClickedSave2)
	ON_BN_CLICKED(IDC_Save3, &CPomeasDualDlg::OnBnClickedSave3)
	ON_BN_CLICKED(IDC_Save4, &CPomeasDualDlg::OnBnClickedSave4)
	ON_BN_CLICKED(IDC_Save5, &CPomeasDualDlg::OnBnClickedSave5)
	ON_BN_CLICKED(IDC_Save6, &CPomeasDualDlg::OnBnClickedSave6)
	ON_BN_CLICKED(IDC_Save7, &CPomeasDualDlg::OnBnClickedSave7)
	ON_BN_CLICKED(IDC_Save8, &CPomeasDualDlg::OnBnClickedSave8)
	ON_BN_CLICKED(IDC_Save9, &CPomeasDualDlg::OnBnClickedSave9)
	ON_BN_CLICKED(IDC_Save10, &CPomeasDualDlg::OnBnClickedSave10)
	ON_BN_CLICKED(IDC_SELECTGOTO1, &CPomeasDualDlg::OnBnClickedSelectgoto1)
	ON_BN_CLICKED(IDC_SELECTGOTO2, &CPomeasDualDlg::OnBnClickedSelectgoto2)
	ON_BN_CLICKED(IDC_SELECTGOTO3, &CPomeasDualDlg::OnBnClickedSelectgoto3)
	ON_BN_CLICKED(IDC_SELECTGOTO4, &CPomeasDualDlg::OnBnClickedSelectgoto4)
	ON_BN_CLICKED(IDC_SELECTGOTO5, &CPomeasDualDlg::OnBnClickedSelectgoto5)
	ON_BN_CLICKED(IDC_SELECTGOTO6, &CPomeasDualDlg::OnBnClickedSelectgoto6)
	ON_BN_CLICKED(IDC_SELECTGOTO7, &CPomeasDualDlg::OnBnClickedSelectgoto7)
	ON_BN_CLICKED(IDC_SELECTGOTO8, &CPomeasDualDlg::OnBnClickedSelectgoto8)
	ON_BN_CLICKED(IDC_SELECTGOTO9, &CPomeasDualDlg::OnBnClickedSelectgoto9)
	ON_BN_CLICKED(IDC_SELECTGOTO10, &CPomeasDualDlg::OnBnClickedSelectgoto10)
	ON_BN_CLICKED(IDC_Goto1, &CPomeasDualDlg::OnBnClickedGoto1)
	ON_BN_CLICKED(IDC_Goto2, &CPomeasDualDlg::OnBnClickedGoto2)
	ON_BN_CLICKED(IDC_Goto3, &CPomeasDualDlg::OnBnClickedGoto3)
	ON_BN_CLICKED(IDC_Goto4, &CPomeasDualDlg::OnBnClickedGoto4)
	ON_BN_CLICKED(IDC_Goto5, &CPomeasDualDlg::OnBnClickedGoto5)
	ON_BN_CLICKED(IDC_Goto6, &CPomeasDualDlg::OnBnClickedGoto6)
	ON_BN_CLICKED(IDC_Goto7, &CPomeasDualDlg::OnBnClickedGoto7)
	ON_BN_CLICKED(IDC_Goto8, &CPomeasDualDlg::OnBnClickedGoto8)
	ON_BN_CLICKED(IDC_Goto9, &CPomeasDualDlg::OnBnClickedGoto9)
	ON_BN_CLICKED(IDC_Goto10, &CPomeasDualDlg::OnBnClickedGoto10)
	ON_BN_CLICKED(IDC_READSTATE, &CPomeasDualDlg::OnBnClickedReadstate)
	ON_BN_CLICKED(IDC_STOPREADSTATE, &CPomeasDualDlg::OnBnClickedStopreadstate)
	ON_BN_CLICKED(IDC_STOPAUTORUN, &CPomeasDualDlg::OnBnClickedStopautorun)
	ON_WM_TIMER()
	ON_WM_CTLCOLOR()
	ON_BN_CLICKED(IDC_OPENSAVEBTN, &CPomeasDualDlg::OnBnClickedOpensavebtn)
	ON_BN_CLICKED(IDC_CLOSESAVEBTN, &CPomeasDualDlg::OnBnClickedClosesavebtn)
	ON_BN_CLICKED(IDC_GETMAXLENGTH, &CPomeasDualDlg::OnBnClickedGetmaxlength)
END_MESSAGE_MAP()


// CPomeasDualDlg message handlers

BOOL CPomeasDualDlg::OnInitDialog()
{
	CDialog::OnInitDialog();

	// Set the icon for this dialog.  The framework does this automatically
	//  when the application's main window is not a dialog
	SetIcon(m_hIcon, TRUE);			// Set big icon
	SetIcon(m_hIcon, FALSE);		// Set small icon

	// TODO: Add extra initialization here
	for(int i=1;i<6;i++)
	{
		CString m_strNum="";
		m_strNum.Format("Com %d",i);
		m_PortsComBox.AddString(m_strNum);
	}
	m_PortsComBox.SetCurSel(m_CommIndex);

	if(!m_CDComm.open(m_CommIndex))
		AfxMessageBox("Open Comm Error");

	m_Select1Btn.SetCheck(m_bMoveTo1);
	m_Select2Btn.SetCheck(m_bMoveTo2);
	m_Select3Btn.SetCheck(m_bMoveTo3);
	m_Select4Btn.SetCheck(m_bMoveTo4);
	m_Select5Btn.SetCheck(m_bMoveTo5);
	m_Select6Btn.SetCheck(m_bMoveTo6);
	m_Select7Btn.SetCheck(m_bMoveTo7);
	m_Select8Btn.SetCheck(m_bMoveTo8);
	m_Select9Btn.SetCheck(m_bMoveTo9);
	m_Select10Btn.SetCheck(m_bMoveTo10);

	m_StateControl.ShowWindow(FALSE);
	m_MotionStateControl.ShowWindow(FALSE);

	m_bStopAutoMove=TRUE;

	OnBnClickedClosesavebtn();

	OnBnClickedStopreadstate();

	SetTimer(1,100,NULL);

	return TRUE;  // return TRUE  unless you set the focus to a control
}

// If you add a minimize button to your dialog, you will need the code below
//  to draw the icon.  For MFC applications using the document/view model,
//  this is automatically done for you by the framework.

void CPomeasDualDlg::OnPaint()
{
	if (IsIconic())
	{
		CPaintDC dc(this); // device context for painting

		SendMessage(WM_ICONERASEBKGND, reinterpret_cast<WPARAM>(dc.GetSafeHdc()), 0);

		// Center icon in client rectangle
		int cxIcon = GetSystemMetrics(SM_CXICON);
		int cyIcon = GetSystemMetrics(SM_CYICON);
		CRect rect;
		GetClientRect(&rect);
		int x = (rect.Width() - cxIcon + 1) / 2;
		int y = (rect.Height() - cyIcon + 1) / 2;

		// Draw the icon
		dc.DrawIcon(x, y, m_hIcon);
	}
	else
	{
		CDialog::OnPaint();
	}
}

// The system calls this function to obtain the cursor to display while the user drags
//  the minimized window.
HCURSOR CPomeasDualDlg::OnQueryDragIcon()
{
	return static_cast<HCURSOR>(m_hIcon);
}


void CPomeasDualDlg::OnCbnSelchangePortscombox()
{
	// TODO: 在此添加控件通知处理程序代码
	m_CDComm.close();

	m_CommIndex=m_PortsComBox.GetCurSel();

	if(!m_CDComm.open(m_CommIndex))
		AfxMessageBox("Open Comm Error");
}

void CPomeasDualDlg::OnBnClickedCancel()
{
	// TODO: 在此添加控件通知处理程序代码
	OnBnClickedStopreadstate();
	OnBnClickedStopautorun();
	OnBnClickedStop();

	KillTimer(1);

	m_CDComm.close();

	//////////////////////////////////////////////////////////////////////////////////////////////////////////////
	//系统参数
	CFile filesystem((CString)GetAppPath()+"System.dat", CFile::modeCreate|CFile::modeWrite);
	CArchive arsystem(&filesystem, CArchive::store|CArchive::bNoFlushOnDelete );

	arsystem <<m_CommIndex;
	arsystem <<m_Port1 <<m_Port2 <<m_Port3 <<m_Port4 <<m_Port5 <<m_Port6 <<m_Port7 <<m_Port8 <<m_Port9 <<m_Port10;
	arsystem <<m_bMoveTo1 <<m_bMoveTo2 <<m_bMoveTo3 <<m_bMoveTo4 <<m_bMoveTo5 <<m_bMoveTo6 <<m_bMoveTo7 <<m_bMoveTo8 <<m_bMoveTo9 <<m_bMoveTo10;
	arsystem <<m_SleepTimer <<m_AutoRunCount;

	arsystem.Flush();
	arsystem.Close();
	filesystem.Close();
	//////////////////////////////////////////////////////////////////////////////////////////////////////////////

	OnCancel();
}

void CPomeasDualDlg::OnBnClickedHome()
{
	// TODO: 在此添加控件通知处理程序代码
	m_CDComm.MoveHome(CDComm::Motor::X);
}

void CPomeasDualDlg::OnBnClickedLimit()
{
	// TODO: 在此添加控件通知处理程序代码
	m_CDComm.MoveLimit(CDComm::Motor::X);
}

void CPomeasDualDlg::OnBnClickedReset()
{
	// TODO: 在此添加控件通知处理程序代码
	m_CDComm.MoveRest(CDComm::Motor::X);
}

void CPomeasDualDlg::OnBnClickedStop()
{
	// TODO: 在此添加控件通知处理程序代码
	m_CDComm.MoveStop(CDComm::Motor::X);
}

void CPomeasDualDlg::OnBnClickedUp()
{
	// TODO: 在此添加控件通知处理程序代码
}

void CPomeasDualDlg::OnBnClickedDown()
{
	// TODO: 在此添加控件通知处理程序代码
}

void CPomeasDualDlg::OnBnClickedDestination()
{
	// TODO: 在此添加控件通知处理程序代码
	UpdateData(TRUE);
	m_CDComm.MoveGoto(CDComm::Motor::X,m_Destination);
	UpdateData(FALSE);
}

void CPomeasDualDlg::OnBnClickedAutorun()
{
	// TODO: 在此添加控件通知处理程序代码
	UpdateData(TRUE);

	if(m_bStopAutoMove)
		::AfxBeginThread(AutoMoveThread,this);

	UpdateData(FALSE);
}

void CPomeasDualDlg::OnBnClickedSave1()
{
	// TODO: 在此添加控件通知处理程序代码
	UpdateData(TRUE);
	m_Port1=m_Destination;
	UpdateData(FALSE);
}

void CPomeasDualDlg::OnBnClickedSave2()
{
	// TODO: 在此添加控件通知处理程序代码
	UpdateData(TRUE);
	m_Port2=m_Destination;
	UpdateData(FALSE);
}

void CPomeasDualDlg::OnBnClickedSave3()
{
	// TODO: 在此添加控件通知处理程序代码
	UpdateData(TRUE);
	m_Port3=m_Destination;
	UpdateData(FALSE);
}

void CPomeasDualDlg::OnBnClickedSave4()
{
	// TODO: 在此添加控件通知处理程序代码
	UpdateData(TRUE);
	m_Port4=m_Destination;
	UpdateData(FALSE);
}

void CPomeasDualDlg::OnBnClickedSave5()
{
	// TODO: 在此添加控件通知处理程序代码
	UpdateData(TRUE);
	m_Port5=m_Destination;
	UpdateData(FALSE);
}

void CPomeasDualDlg::OnBnClickedSave6()
{
	// TODO: 在此添加控件通知处理程序代码
	UpdateData(TRUE);
	m_Port6=m_Destination;
	UpdateData(FALSE);
}

void CPomeasDualDlg::OnBnClickedSave7()
{
	// TODO: 在此添加控件通知处理程序代码
	UpdateData(TRUE);
	m_Port7=m_Destination;
	UpdateData(FALSE);
}

void CPomeasDualDlg::OnBnClickedSave8()
{
	// TODO: 在此添加控件通知处理程序代码
	UpdateData(TRUE);
	m_Port8=m_Destination;
	UpdateData(FALSE);
}

void CPomeasDualDlg::OnBnClickedSave9()
{
	// TODO: 在此添加控件通知处理程序代码
	UpdateData(TRUE);
	m_Port9=m_Destination;
	UpdateData(FALSE);
}

void CPomeasDualDlg::OnBnClickedSave10()
{
	// TODO: 在此添加控件通知处理程序代码
	UpdateData(TRUE);
	m_Port10=m_Destination;
	UpdateData(FALSE);
}

void CPomeasDualDlg::OnBnClickedSelectgoto1()
{
	// TODO: 在此添加控件通知处理程序代码
	m_bMoveTo1=!m_bMoveTo1;
	m_Select1Btn.SetCheck(m_bMoveTo1);
}

void CPomeasDualDlg::OnBnClickedSelectgoto2()
{
	// TODO: 在此添加控件通知处理程序代码
	m_bMoveTo2=!m_bMoveTo2;
	m_Select2Btn.SetCheck(m_bMoveTo2);
}

void CPomeasDualDlg::OnBnClickedSelectgoto3()
{
	// TODO: 在此添加控件通知处理程序代码
	m_bMoveTo3=!m_bMoveTo3;
	m_Select3Btn.SetCheck(m_bMoveTo3);
}

void CPomeasDualDlg::OnBnClickedSelectgoto4()
{
	// TODO: 在此添加控件通知处理程序代码
	m_bMoveTo4=!m_bMoveTo4;
	m_Select4Btn.SetCheck(m_bMoveTo4);
}

void CPomeasDualDlg::OnBnClickedSelectgoto5()
{
	// TODO: 在此添加控件通知处理程序代码
	m_bMoveTo5=!m_bMoveTo5;
	m_Select5Btn.SetCheck(m_bMoveTo5);
}

void CPomeasDualDlg::OnBnClickedSelectgoto6()
{
	// TODO: 在此添加控件通知处理程序代码
	m_bMoveTo6=!m_bMoveTo6;
	m_Select6Btn.SetCheck(m_bMoveTo6);
}

void CPomeasDualDlg::OnBnClickedSelectgoto7()
{
	// TODO: 在此添加控件通知处理程序代码
	m_bMoveTo7=!m_bMoveTo7;
	m_Select7Btn.SetCheck(m_bMoveTo7);
}

void CPomeasDualDlg::OnBnClickedSelectgoto8()
{
	// TODO: 在此添加控件通知处理程序代码
	m_bMoveTo8=!m_bMoveTo8;
	m_Select8Btn.SetCheck(m_bMoveTo8);
}

void CPomeasDualDlg::OnBnClickedSelectgoto9()
{
	// TODO: 在此添加控件通知处理程序代码
	m_bMoveTo9=!m_bMoveTo9;
	m_Select9Btn.SetCheck(m_bMoveTo9);
}

void CPomeasDualDlg::OnBnClickedSelectgoto10()
{
	// TODO: 在此添加控件通知处理程序代码
	m_bMoveTo10=!m_bMoveTo10;
	m_Select10Btn.SetCheck(m_bMoveTo10);
}

void CPomeasDualDlg::OnBnClickedGoto1()
{
	// TODO: 在此添加控件通知处理程序代码
	UpdateData(TRUE);
	m_Destination=m_Port1;
	m_CDComm.MoveGoto(CDComm::Motor::X,m_Destination);
	UpdateData(FALSE);
}

void CPomeasDualDlg::OnBnClickedGoto2()
{
	// TODO: 在此添加控件通知处理程序代码
	UpdateData(TRUE);
	m_Destination=m_Port2;
	m_CDComm.MoveGoto(CDComm::Motor::X,m_Destination);
	UpdateData(FALSE);
}

void CPomeasDualDlg::OnBnClickedGoto3()
{
	// TODO: 在此添加控件通知处理程序代码
	UpdateData(TRUE);
	m_Destination=m_Port3;
	m_CDComm.MoveGoto(CDComm::Motor::X,m_Destination);
	UpdateData(FALSE);
}

void CPomeasDualDlg::OnBnClickedGoto4()
{
	// TODO: 在此添加控件通知处理程序代码
	UpdateData(TRUE);
	m_Destination=m_Port4;
	m_CDComm.MoveGoto(CDComm::Motor::X,m_Destination);
	UpdateData(FALSE);
}

void CPomeasDualDlg::OnBnClickedGoto5()
{
	// TODO: 在此添加控件通知处理程序代码
	UpdateData(TRUE);
	m_Destination=m_Port5;
	m_CDComm.MoveGoto(CDComm::Motor::X,m_Destination);
	UpdateData(FALSE);
}

void CPomeasDualDlg::OnBnClickedGoto6()
{
	// TODO: 在此添加控件通知处理程序代码
	UpdateData(TRUE);
	m_Destination=m_Port6;
	m_CDComm.MoveGoto(CDComm::Motor::X,m_Destination);
	UpdateData(FALSE);
}

void CPomeasDualDlg::OnBnClickedGoto7()
{
	// TODO: 在此添加控件通知处理程序代码
	UpdateData(TRUE);
	m_Destination=m_Port7;
	m_CDComm.MoveGoto(CDComm::Motor::X,m_Destination);
	UpdateData(FALSE);
}

void CPomeasDualDlg::OnBnClickedGoto8()
{
	// TODO: 在此添加控件通知处理程序代码
	UpdateData(TRUE);
	m_Destination=m_Port8;
	m_CDComm.MoveGoto(CDComm::Motor::X,m_Destination);
	UpdateData(FALSE);
}

void CPomeasDualDlg::OnBnClickedGoto9()
{
	// TODO: 在此添加控件通知处理程序代码
	UpdateData(TRUE);
	m_Destination=m_Port9;
	m_CDComm.MoveGoto(CDComm::Motor::X,m_Destination);
	UpdateData(FALSE);
}

void CPomeasDualDlg::OnBnClickedGoto10()
{
	// TODO: 在此添加控件通知处理程序代码
	UpdateData(TRUE);
	m_Destination=m_Port10;
	m_CDComm.MoveGoto(CDComm::Motor::X,m_Destination);
	UpdateData(FALSE);
}

void CPomeasDualDlg::OnBnClickedReadstate()
{
	// TODO: 在此添加控件通知处理程序代码
	m_GetStateBtn.EnableWindow(FALSE);
	m_StopGetStateBtn.EnableWindow(TRUE);

	SetTimer(0,1000,NULL);
	m_StateControl.ShowWindow(TRUE);
	m_MotionStateControl.ShowWindow(TRUE);
}

void CPomeasDualDlg::OnBnClickedStopreadstate()
{
	// TODO: 在此添加控件通知处理程序代码
	KillTimer(0);
	m_StateControl.ShowWindow(FALSE);
	m_MotionStateControl.ShowWindow(FALSE);

	m_GetStateBtn.EnableWindow(TRUE);
	m_StopGetStateBtn.EnableWindow(FALSE);
}

void CPomeasDualDlg::OnBnClickedStopautorun()
{
	// TODO: 在此添加控件通知处理程序代码
	m_bStopAutoMove=TRUE;
}

void CPomeasDualDlg::OnTimer(UINT_PTR nIDEvent)
{
	// TODO: 在此添加消息处理程序代码和/或调用默认值
	switch(nIDEvent)
	{
	case 0:
		{
			long pos=m_CDComm.MovePos(CDComm::Motor::X);
			CString str;
			str.Format("%d",pos);
			m_StateControl.SetWindowTextA(str);

			if(m_CDComm.MoveStatus(CDComm::Motor::X)==0)
				m_MotionStateControl.SetWindowTextA("Moving");
			else
				m_MotionStateControl.SetWindowTextA("Stop");

			break;
		}
	case 1:
		{
			SetDlgItemInt(IDC_AUTORUNINDEX,m_AutoRunIndex,TRUE);
			SetDlgItemInt(IDC_AUTORUNSTEP,m_AutoRunStep,TRUE);
			break;
		}
	}

	CDialog::OnTimer(nIDEvent);
}

UINT CPomeasDualDlg::AutoMoveThread(LPVOID lParam)
{
	CPomeasDualDlg* pDlg=(CPomeasDualDlg*)lParam;
	if(!pDlg) return 0;

	pDlg->m_bStopAutoMove=FALSE;

	pDlg->m_AutoRunIndex=0;
	pDlg->m_AutoRunStep=0;
	pDlg->m_AutoRunStep=1;
	while(1)
	{
		if(pDlg->m_bStopAutoMove)
		{
			m_CDComm.MoveStop(CDComm::Motor::X);

			::AfxEndThread(0);
			return 0;
		}
		else
		{
			if(pDlg->m_AutoRunStep==1)
			{
				if(pDlg->m_bMoveTo1)
				{
					if(m_CDComm.MoveStatus(CDComm::Motor::X)!=0)
					{
						Sleep(pDlg->m_SleepTimer);
						m_CDComm.MoveGoto(CDComm::Motor::X,pDlg->m_Port1);
						pDlg->m_AutoRunStep++;
					}
				}
				else pDlg->m_AutoRunStep++;
			}
			else if(pDlg->m_AutoRunStep==2)
			{
				if(pDlg->m_bMoveTo2)
				{
					if(m_CDComm.MoveStatus(CDComm::Motor::X)!=0)
					{
						Sleep(pDlg->m_SleepTimer);
						m_CDComm.MoveGoto(CDComm::Motor::X,pDlg->m_Port2);
						pDlg->m_AutoRunStep++;
					}
				}
				else pDlg->m_AutoRunStep++;
			}
			else if(pDlg->m_AutoRunStep==3)
			{
				if(pDlg->m_bMoveTo3)
				{
					if(m_CDComm.MoveStatus(CDComm::Motor::X)!=0)
					{
						Sleep(pDlg->m_SleepTimer);
						m_CDComm.MoveGoto(CDComm::Motor::X,pDlg->m_Port3);
						pDlg->m_AutoRunStep++;
					}
				}
				else pDlg->m_AutoRunStep++;
			}
			else if(pDlg->m_AutoRunStep==4)
			{
				if(pDlg->m_bMoveTo4)
				{
					if(m_CDComm.MoveStatus(CDComm::Motor::X)!=0)
					{
						Sleep(pDlg->m_SleepTimer);
						m_CDComm.MoveGoto(CDComm::Motor::X,pDlg->m_Port4);
						pDlg->m_AutoRunStep++;
					}
				}
				else pDlg->m_AutoRunStep++;
			}
			else if(pDlg->m_AutoRunStep==5)
			{
				if(pDlg->m_bMoveTo5)
				{
					if(m_CDComm.MoveStatus(CDComm::Motor::X)!=0)
					{
						Sleep(pDlg->m_SleepTimer);
						m_CDComm.MoveGoto(CDComm::Motor::X,pDlg->m_Port5);
						pDlg->m_AutoRunStep++;
					}
				}
				else pDlg->m_AutoRunStep++;
			}
			else if(pDlg->m_AutoRunStep==6)
			{
				if(pDlg->m_bMoveTo6)
				{
					if(m_CDComm.MoveStatus(CDComm::Motor::X)!=0)
					{
						Sleep(pDlg->m_SleepTimer);
						m_CDComm.MoveGoto(CDComm::Motor::X,pDlg->m_Port6);
						pDlg->m_AutoRunStep++;
					}
				}
				else pDlg->m_AutoRunStep++;
			}
			else if(pDlg->m_AutoRunStep==7)
			{
				if(pDlg->m_bMoveTo7)
				{
					if(m_CDComm.MoveStatus(CDComm::Motor::X)!=0)
					{
						Sleep(pDlg->m_SleepTimer);
						m_CDComm.MoveGoto(CDComm::Motor::X,pDlg->m_Port7);
						pDlg->m_AutoRunStep++;
					}
				}
				else pDlg->m_AutoRunStep++;
			}
			else if(pDlg->m_AutoRunStep==8)
			{
				if(pDlg->m_bMoveTo8)
				{
					if(m_CDComm.MoveStatus(CDComm::Motor::X)!=0)
					{
						Sleep(pDlg->m_SleepTimer);
						m_CDComm.MoveGoto(CDComm::Motor::X,pDlg->m_Port8);
						pDlg->m_AutoRunStep++;
					}
				}
				else pDlg->m_AutoRunStep++;
			}
			else if(pDlg->m_AutoRunStep==9)
			{
				if(pDlg->m_bMoveTo9)
				{
					if(m_CDComm.MoveStatus(CDComm::Motor::X)!=0)
					{
						Sleep(pDlg->m_SleepTimer);
						m_CDComm.MoveGoto(CDComm::Motor::X,pDlg->m_Port9);
						pDlg->m_AutoRunStep++;
					}
				}
				else pDlg->m_AutoRunStep++;
			}
			else if(pDlg->m_AutoRunStep==10)
			{
				if(pDlg->m_bMoveTo10)
				{
					if(m_CDComm.MoveStatus(CDComm::Motor::X)!=0)
					{
						Sleep(pDlg->m_SleepTimer);
						m_CDComm.MoveGoto(CDComm::Motor::X,pDlg->m_Port10);

						pDlg->m_AutoRunStep=1;
						pDlg->m_AutoRunIndex++;
						if(pDlg->m_AutoRunIndex>=pDlg->m_AutoRunCount)
						{
							while(m_CDComm.MoveStatus(CDComm::Motor::X)==0) Sleep(100);
							pDlg->OnBnClickedStopautorun();
						}
					}
				}
				else
				{
					pDlg->m_AutoRunStep=1;
					pDlg->m_AutoRunIndex++;
					if(pDlg->m_AutoRunIndex>=pDlg->m_AutoRunCount)
					{
						while(m_CDComm.MoveStatus(CDComm::Motor::X)==0) Sleep(100);
						pDlg->OnBnClickedStopautorun();
					}
				}
			}
		}

		Sleep(100);
	}

	return 0;
}

HBRUSH CPomeasDualDlg::OnCtlColor(CDC* pDC, CWnd* pWnd, UINT nCtlColor)
{
	HBRUSH hbr = CDialog::OnCtlColor(pDC, pWnd, nCtlColor);

	// TODO:  在此更改 DC 的任何属性
	if(pWnd->GetDlgCtrlID()==IDC_TITLEC)
	{
		CFont font;
		font.CreateFont(36,0,0,0,0,0,0,0,ANSI_CHARSET,OUT_DEFAULT_PRECIS,
			CLIP_DEFAULT_PRECIS,DEFAULT_QUALITY,DEFAULT_PITCH|FF_SWISS,"Times New Roman");
		pDC->SelectObject(&font);

	    pDC->SetBkMode(TRANSPARENT);
	    pDC->SetTextColor(RGB(0,255,0));
		hbr=m_Brush;
	}
	else if(pWnd->GetDlgCtrlID()==IDC_STATE)
	{
		CFont font;
		font.CreateFont(32,0,0,0,0,0,0,0,ANSI_CHARSET,OUT_DEFAULT_PRECIS,
			CLIP_DEFAULT_PRECIS,DEFAULT_QUALITY,DEFAULT_PITCH|FF_SWISS,"Times New Roman");
		pDC->SelectObject(&font);

	    pDC->SetBkMode(TRANSPARENT);
	    pDC->SetTextColor(RGB(0,255,0));
		hbr=m_Brush;
	}

	// TODO:  如果默认的不是所需画笔，则返回另一个画笔
	return hbr;
}

void CPomeasDualDlg::OnBnClickedOpensavebtn()
{
	// TODO: 在此添加控件通知处理程序代码
	m_Save1Btn.EnableWindow(TRUE);
	m_Save2Btn.EnableWindow(TRUE);
	m_Save3Btn.EnableWindow(TRUE);
	m_Save4Btn.EnableWindow(TRUE);
	m_Save5Btn.EnableWindow(TRUE);
	m_Save6Btn.EnableWindow(TRUE);
	m_Save7Btn.EnableWindow(TRUE);
	m_Save8Btn.EnableWindow(TRUE);
	m_Save9Btn.EnableWindow(TRUE);
	m_Save10Btn.EnableWindow(TRUE);
}

void CPomeasDualDlg::OnBnClickedClosesavebtn()
{
	// TODO: 在此添加控件通知处理程序代码
	m_Save1Btn.EnableWindow(FALSE);
	m_Save2Btn.EnableWindow(FALSE);
	m_Save3Btn.EnableWindow(FALSE);
	m_Save4Btn.EnableWindow(FALSE);
	m_Save5Btn.EnableWindow(FALSE);
	m_Save6Btn.EnableWindow(FALSE);
	m_Save7Btn.EnableWindow(FALSE);
	m_Save8Btn.EnableWindow(FALSE);
	m_Save9Btn.EnableWindow(FALSE);
	m_Save10Btn.EnableWindow(FALSE);
}

void CPomeasDualDlg::OnBnClickedGetmaxlength()
{
	// TODO: 在此添加控件通知处理程序代码
	long maxLength=m_CDComm.MoveMaxLength(CDComm::Motor::X);
	CString str;
	str.Format("%d",maxLength);
	m_maxLengthStatic.SetWindowTextA(str);
}
