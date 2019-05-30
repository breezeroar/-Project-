// test.cpp: 實作檔案
//

#include "stdafx.h"
#include "MFCApplication1.h"
#include "test.h"
#include "afxdialogex.h"


// test 對話方塊

IMPLEMENT_DYNAMIC(test, CDialogEx)

test::test(CWnd* pParent /*=nullptr*/)
	: CDialogEx(IDD_DIALOG1, pParent)
{

}

test::~test()
{
}

void test::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
}


BEGIN_MESSAGE_MAP(test, CDialogEx)
END_MESSAGE_MAP()


// test 訊息處理常式
