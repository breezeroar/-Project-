#pragma once


// test 對話方塊

class test : public CDialogEx
{
	DECLARE_DYNAMIC(test)

public:
	test(CWnd* pParent = nullptr);   // 標準建構函式
	virtual ~test();

// 對話方塊資料
#ifdef AFX_DESIGN_TIME
	enum { IDD = IDD_DIALOG1 };
#endif

protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV 支援

	DECLARE_MESSAGE_MAP()
};
