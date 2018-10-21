using Assets.Scripts.EnemyFeatureDevelopment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.EnemyHQ
{
    public class HqUnitFeatures : MonoBehaviour, IFeatures
    {
        [SerializeField]
        private double armySpawnInterval;
        [SerializeField]
        private int maxArmyOfUnit;
        [SerializeField]
        private double featureDevelopmentInterval;
        [SerializeField]
        private float maxHealth;
        [SerializeField]
        private float curentHealth;

        /// <summary>
        /// Army spawn interval in seconds
        /// Developable feature 
        /// </summary>
        public double ArmySpawnInterval
        {
            get { return armySpawnInterval; }
            set { armySpawnInterval = value; }
        }

        /// <summary>
        /// Max size of sub army.
        /// Developable feature 
        /// </summary>
        public int MaxArmyOfUnit
        {
            get { return maxArmyOfUnit; }
            set { maxArmyOfUnit = value; }
        }

        /// <summary>
        /// Feature development interval.
        /// Developable feature
        /// </summary>
        public double FeatureDevelopmentInterval
        {
            get { return featureDevelopmentInterval; }
            set { featureDevelopmentInterval = value; }
        }

        /// <summary>
        /// Max value of enemy health
        /// </summary>
        public float MaxTechnicalCondition
        {
            get { return maxHealth; }
            set { maxHealth = value; }
        }

        /// <summary>
        /// Enemy current value of health
        /// </summary>
        public float CurrentTechnicalCondition
        {
            get { return curentHealth; }
            set { curentHealth = value; }
        }
    }
}
