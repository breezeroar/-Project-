namespace ChangeCamMagnification
{

    public class PomeasCam : PomeasDll
    {
        public bool OpenComm(int index, int port)
        {
            bool checkComm = Pomeas_OpenComm(index, port);
            return checkComm;
        }

        public void CloseComm(int index)
        {
            Pomeas_CloseComm(index);
        }

        public int MaxLength(int index)
        {
            int length = Pomeas_MoveMaxLength(index);
            return length;
        }

        public void Home(int index)
        {
            Pomeas_MoveHome(index);
        }
        public void Goto(int index, long dst)
        {
            Pomeas_MoveGoto(index, dst);
        }
        public int Status(int index)
        {
            int status = Pomeas_MoveStatus(index);
            return status;
        }
        public int Position(int index)
        {
            int position = Pomeas_MovePos(index);
            return position;
        }

    }
}
