
// OpenCV_Try_C++.h: PROJECT_NAME 應用程式的主要標頭檔
//

#pragma once

#ifndef __AFXWIN_H__
	#error "對 PCH 包含此檔案前先包含 'stdafx.h'"
#endif

#include "resource.h"		// 主要符號


// COpenCVTryCApp:
// 查看 OpenCV_Try_C++.cpp 以了解此類別的實作
//

class COpenCVTryCApp : public CWinApp
{
public:
	COpenCVTryCApp();

// 覆寫
public:
	virtual BOOL InitInstance();

// 程式碼實作

	DECLARE_MESSAGE_MAP()
};

extern COpenCVTryCApp theApp;
