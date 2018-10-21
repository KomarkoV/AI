using Assets.Scripts.EnemyFeatureDevelopment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.EnemySoldiers
{
    public class SoldierBaseFeatures : MonoBehaviour, IFeatures
    {
        [SerializeField]
        private float rangeOfView;
        [SerializeField]
        private float maxHealth;
        [SerializeField]
        private float curentHealth;
        [SerializeField]
        private double featureDevelopmentInterval;

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

        public double FeatureDevelopmentInterval
        {
            get { return featureDevelopmentInterval; }
            set { featureDevelopmentInterval = value; }
        }
    }
}
