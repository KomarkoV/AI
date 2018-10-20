using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Communication
{
    public interface ICommunicator
    {
        void SendData<T>(T data);
        T ReceiveData<T>();
    }
}
