using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.EnemySoldiers
{
    public class SoldierBaseFeatures : MonoBehaviour
    {
        [SerializeField]
        private float rangeOfView;
        [SerializeField]
        private float maxHealth;
        [SerializeField]
        private float curentHealth;

        /// <summary>
        /// Enemy's range of view
        /// </summary>
        public float RangeOfView
        {
            get { return rangeOfView; }
            set { rangeOfView = value; }
        }

        /// <summary>
        /// Max value of enemy health
        /// </summary>
        public float MaxHealth
        {
            get { return maxHealth; }
            set { maxHealth = value; }
        }

        /// <summary>
        /// Enemy current value of health
        /// </summary>
        public float CurentHealth
        {
            get { return curentHealth; }
            set { curentHealth = value; }
        }
    }
}
