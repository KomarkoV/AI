using Assets.Scripts.Communication;
using System;

namespace Assets.Scripts.EnemySoldiers
{
    public class SoldiersCommunicator : ICommunicator
    {
        public T ReceiveData<T>()
        {
            throw new NotImplementedException();
        }

        public void SendData<T>(T data)
        {
            throw new NotImplementedException();
        }
    }
}
