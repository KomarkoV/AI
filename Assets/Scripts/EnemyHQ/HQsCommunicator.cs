using Assets.Scripts.Communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.EnemyHQ
{
    public class HqsCommunicator : ICommunicator
    {
        private List<GameObject> soldiers;

        public HqsCommunicator(List<GameObject> soldiers)
        {
            this.soldiers = soldiers;
        }

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
