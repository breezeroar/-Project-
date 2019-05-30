// PomeasDualDll.h : PomeasDualDll DLL ����ͷ�ļ�
//

#pragma once


#include <windows.h>
#include <string>

#pragma warning(disable: 4482)

class _declspec(dllexport) CDComm  
{
public:
	enum Motor { X = 'X',Y='Y' };	// an enumeration for the motors.
	enum Command { Limit='L', Home='H', Stop='S', Up='U', Down='D', Reset='R' ,Goto='G',Statius='Z',maxLength='M',Pos='N'}; // an enumeration for the commands.
	enum Error { m_eoc='\x00D' }; // ctor.

public:
	BOOL open(int port);
	void close();

	CDComm();
	virtual ~CDComm();

	void write(const char * data, int *length);
	
private:

	DCB m_dcb;
	HANDLE m_hCom;
	HANDLE m_hMutex;

	bool m_initialized;
	int m_port;

public:
	//�˶��������
	void MoveLimit(Motor m);
	//�ػ�еԭ��
	void MoveHome(Motor m);
	//ֹͣ�䱶
	void MoveStop(Motor m);
	//�Ŵ�
	void MoveUp(Motor m);
	//��С
	void MoveDown(Motor m);
	//��λ
	void MoveRest(Motor m);
	//�˶���ָ��λ��
	void MoveGoto(Motor m,long dest);
	//��ȡ�˶�״̬,����0Ϊ�˶�״̬��1Ϊֹͣ״̬��2Ϊ��ʼ��ʧ��
	int MoveStatus(Motor m);
	//��ȡ�ܳ���
	long MoveMaxLength(Motor m);
	//��ȡ��ǰλ��
	long MovePos(Motor m);
};
