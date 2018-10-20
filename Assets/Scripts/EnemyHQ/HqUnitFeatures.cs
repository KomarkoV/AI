using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.EnemyHQ
{
    public class HqUnitFeatures : MonoBehaviour
    {
        [SerializeField]
        private double armySpawnInterval;
        [SerializeField]
        private int maxArmyOfUnit;

        /// <summary>
        /// Army spawn interval in seconds
        /// Developable enemy feature 
        /// </summary>
        public double ArmySpawnInterval
        {
            get { return armySpawnInterval; }
            set { armySpawnInterval = value; }
        }

        /// <summary>
        /// Max size of sub army.
        /// Developable enemy feature 
        /// </summary>
        public int MaxArmyOfUnit
        {
            get { return maxArmyOfUnit; }
            set { maxArmyOfUnit = value; }
        }
    }
}
