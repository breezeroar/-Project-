#pragma once
#include "XPButton.h"


// CMoveUpButton

class CMoveUpButton : public CXPButton
{
	DECLARE_DYNAMIC(CMoveUpButton)

public:
	CMoveUpButton();
	virtual ~CMoveUpButton();

protected:
	DECLARE_MESSAGE_MAP()
public:
	afx_msg void OnLButtonDown(UINT nFlags, CPoint point);
public:
	afx_msg void OnLButtonUp(UINT nFlags, CPoint point);
public:
	afx_msg void OnMouseMove(UINT nFlags, CPoint point);
};





// CMoveDownButton

class CMoveDownButton : public CXPButton
{
	DECLARE_DYNAMIC(CMoveDownButton)

public:
	CMoveDownButton();
	virtual ~CMoveDownButton();

protected:
	DECLARE_MESSAGE_MAP()
public:
	afx_msg void OnLButtonDown(UINT nFlags, CPoint point);
public:
	afx_msg void OnLButtonUp(UINT nFlags, CPoint point);
public:
	afx_msg void OnMouseMove(UINT nFlags, CPoint point);
};

