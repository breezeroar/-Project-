
// BaslerCam_OpenCV_Test.h: PROJECT_NAME 應用程式的主要標頭檔
//

#pragma once

#ifndef __AFXWIN_H__
	#error "對 PCH 包含此檔案前先包含 'stdafx.h'"
#endif

#include "resource.h"		// 主要符號


// CBaslerCamOpenCVTestApp:
// 查看 BaslerCam_OpenCV_Test.cpp 以了解此類別的實作
//

class CBaslerCamOpenCVTestApp : public CWinApp
{
public:
	CBaslerCamOpenCVTestApp();

// 覆寫
public:
	virtual BOOL InitInstance();

// 程式碼實作

	DECLARE_MESSAGE_MAP()
};

extern CBaslerCamOpenCVTestApp theApp;
