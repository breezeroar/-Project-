// PomeasDualDll.h : PomeasDualDll DLL ����ͷ�ļ�
//

//DrvIndex=0,���Ƶ�һ�˿�
//DrvIndex=1,���Ƶڶ��˿�
//port+1Ϊ��Ӧ�Ĵ��ں�

//�򿪴���
extern "C" _declspec(dllexport) bool Pomeas_OpenComm(int DrvIndex,int port);

//�رմ���
extern "C" _declspec(dllexport) void Pomeas_CloseComm(int DrvIndex);

//�˶��������
extern "C" _declspec(dllexport) void Pomeas_MoveLimit(int DrvIndex);

//�ػ�еԭ��
extern "C" _declspec(dllexport) void Pomeas_MoveHome(int DrvIndex);

//ֹͣ�䱶
extern "C" _declspec(dllexport) void Pomeas_MoveStop(int DrvIndex);

//�Ŵ�
extern "C" _declspec(dllexport) void Pomeas_MoveUp(int DrvIndex);

//int DrvIndex
extern "C" _declspec(dllexport) void Pomeas_MoveDown(int DrvIndex);

//��λ
extern "C" _declspec(dllexport) void Pomeas_MoveRest(int DrvIndex);

//�˶���ָ��λ��
extern "C" _declspec(dllexport) void Pomeas_MoveGoto(int DrvIndex,long dest);

//��ȡ�˶�״̬,����0Ϊ�˶�״̬��1Ϊֹͣ״̬��2Ϊ��ʼ��ʧ��
extern "C" _declspec(dllexport) int Pomeas_MoveStatus(int DrvIndex);

//��ȡ����г�
extern "C" _declspec(dllexport) int Pomeas_MoveMaxLength(int DrvIndex);

//��ȡ��ǰλ��
extern "C" _declspec(dllexport) int Pomeas_MovePos(int DrvIndex);