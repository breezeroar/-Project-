// PomeasDualDll.h : PomeasDualDll DLL 的主头文件
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
	//运动到最大倍数
	void MoveLimit(Motor m);
	//回机械原点
	void MoveHome(Motor m);
	//停止变倍
	void MoveStop(Motor m);
	//放大
	void MoveUp(Motor m);
	//缩小
	void MoveDown(Motor m);
	//复位
	void MoveRest(Motor m);
	//运动到指定位置
	void MoveGoto(Motor m,long dest);
	//获取运动状态,返回0为运动状态，1为停止状态，2为初始化失败
	int MoveStatus(Motor m);
	//获取总长度
	long MoveMaxLength(Motor m);
	//获取当前位置
	long MovePos(Motor m);
};
