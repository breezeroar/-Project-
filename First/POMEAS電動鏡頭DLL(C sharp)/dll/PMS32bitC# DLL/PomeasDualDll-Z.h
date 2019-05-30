// PomeasDualDll.h : PomeasDualDll DLL 的主头文件
//

//DrvIndex=0,控制第一端口
//DrvIndex=1,控制第二端口
//port+1为对应的串口号

//打开串口
extern "C" _declspec(dllexport) bool Pomeas_OpenComm(int DrvIndex,int port);

//关闭串口
extern "C" _declspec(dllexport) void Pomeas_CloseComm(int DrvIndex);

//运动到最大倍数
extern "C" _declspec(dllexport) void Pomeas_MoveLimit(int DrvIndex);

//回机械原点
extern "C" _declspec(dllexport) void Pomeas_MoveHome(int DrvIndex);

//停止变倍
extern "C" _declspec(dllexport) void Pomeas_MoveStop(int DrvIndex);

//放大
extern "C" _declspec(dllexport) void Pomeas_MoveUp(int DrvIndex);

//int DrvIndex
extern "C" _declspec(dllexport) void Pomeas_MoveDown(int DrvIndex);

//复位
extern "C" _declspec(dllexport) void Pomeas_MoveRest(int DrvIndex);

//运动到指定位置
extern "C" _declspec(dllexport) void Pomeas_MoveGoto(int DrvIndex,long dest);

//获取运动状态,返回0为运动状态，1为停止状态，2为初始化失败
extern "C" _declspec(dllexport) int Pomeas_MoveStatus(int DrvIndex);

//获取最大行程
extern "C" _declspec(dllexport) int Pomeas_MoveMaxLength(int DrvIndex);

//获取当前位置
extern "C" _declspec(dllexport) int Pomeas_MovePos(int DrvIndex);