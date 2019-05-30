using System.Runtime.InteropServices;

namespace ChangeCamMagnification
{
    public class PomeasDll
    {
        [DllImport("PomeasDualDll-Z.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool Pomeas_OpenComm(int DrvIndex, int port);

        [DllImport("PomeasDualDll-Z.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Pomeas_CloseComm(int DrvIndex);

        [DllImport("PomeasDualDll-Z.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Pomeas_MoveLimit(int DrvIndex);

        [DllImport("PomeasDualDll-Z.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Pomeas_MoveHome(int DrvIndex);

        [DllImport("PomeasDualDll-Z.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Pomeas_MoveStop(int DrvIndex);

        [DllImport("PomeasDualDll-Z.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Pomeas_MoveUp(int DrvIndex);

        [DllImport("PomeasDualDll-Z.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Pomeas_MoveDown(int DrvIndex);

        [DllImport("PomeasDualDll-Z.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Pomeas_MoveRest(int DrvIndex);

        [DllImport("PomeasDualDll-Z.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Pomeas_MoveGoto(int DrvIndex, long dest);

        [DllImport("PomeasDualDll-Z.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Pomeas_MoveStatus(int DrvIndex);

        [DllImport("PomeasDualDll-Z.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Pomeas_MoveMaxLength(int DrvIndex);

        [DllImport("PomeasDualDll-Z.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Pomeas_MovePos(int DrvIndex);
    }

}
