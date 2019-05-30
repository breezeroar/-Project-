// MyButton.cpp : ʵ���ļ�
//

#include "stdafx.h"
#include "Pomeas Dual.h"
#include "MyButton.h"


// CMoveUpButton

IMPLEMENT_DYNAMIC(CMoveUpButton, CButton)

CMoveUpButton::CMoveUpButton()
{

}

CMoveUpButton::~CMoveUpButton()
{
}


BEGIN_MESSAGE_MAP(CMoveUpButton, CButton)
	ON_WM_LBUTTONDOWN()
	ON_WM_LBUTTONUP()
	ON_WM_MOUSEMOVE()
END_MESSAGE_MAP()



// CMoveUpButton ��Ϣ�������



void CMoveUpButton::OnLButtonDown(UINT nFlags, CPoint point)
{
	// TODO: �ڴ������Ϣ�����������/�����Ĭ��ֵ
	m_CDComm.MoveUp(CDComm::Motor::X);

	CButton::OnLButtonDown(nFlags, point);
}

void CMoveUpButton::OnLButtonUp(UINT nFlags, CPoint point)
{
	// TODO: �ڴ������Ϣ�����������/�����Ĭ��ֵ
	m_CDComm.MoveStop(CDComm::Motor::X);

	CButton::OnLButtonUp(nFlags, point);
}

void CMoveUpButton::OnMouseMove(UINT nFlags, CPoint point)
{
	// TODO: �ڴ������Ϣ�����������/�����Ĭ��ֵ

	CXPButton::OnMouseMove(nFlags, point);
}





// CMoveDownButton

IMPLEMENT_DYNAMIC(CMoveDownButton, CButton)

CMoveDownButton::CMoveDownButton()
{

}

CMoveDownButton::~CMoveDownButton()
{
}


BEGIN_MESSAGE_MAP(CMoveDownButton, CButton)
	ON_WM_LBUTTONDOWN()
	ON_WM_LBUTTONUP()
	ON_WM_MOUSEMOVE()
END_MESSAGE_MAP()



// CMoveDownButton ��Ϣ�������



void CMoveDownButton::OnLButtonDown(UINT nFlags, CPoint point)
{
	// TODO: �ڴ������Ϣ�����������/�����Ĭ��ֵ
	m_CDComm.MoveDown(CDComm::Motor::X);

	CButton::OnLButtonDown(nFlags, point);
}

void CMoveDownButton::OnLButtonUp(UINT nFlags, CPoint point)
{
	// TODO: �ڴ������Ϣ�����������/�����Ĭ��ֵ
	m_CDComm.MoveStop(CDComm::Motor::X);

	CButton::OnLButtonUp(nFlags, point);
}

void CMoveDownButton::OnMouseMove(UINT nFlags, CPoint point)
{
	// TODO: �ڴ������Ϣ�����������/�����Ĭ��ֵ

	CXPButton::OnMouseMove(nFlags, point);
}
