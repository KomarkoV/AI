using Assets.Scripts.Communication;
using Assets.Scripts.EnemyFeatureDevelopment;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.EnemySoldiers
{
    public class EnemySoldier : MonoBehaviour
    {
        private Cache cache;
        private ICommunicator communicator;
        private SoldierBaseFeatures soldierFeatures;
        private IFeatureDevelopment featureDevelopment;

        [SerializeField]
        private string hqUnitId;
        [SerializeField]
        private string enemyId;

        /// <summary>
        /// Identity of enemy soldier
        /// </summary>
        public string EnemyId
        {
            get { return enemyId; }
            set { enemyId = value; }
        }

        /// <summary>
        /// Identity of heaquarters unit which enemy soldier is subject
        /// </summary>
        public string HqUnitId
        {
            get { return hqUnitId; }
            set { hqUnitId = value; }
        }

        public SoldierBaseFeatures SoldierFeatures
        {
            get
            {
                if (!soldierFeatures)
                    soldierFeatures = GetComponent(nameof(SoldierBaseFeatures)) as SoldierBaseFeatures;
                return soldierFeatures;
            }
        }

        /// <summary>
        /// Use this for initialization 
        /// </summary>
        void Start()
        {
            enemyId = string.IsNullOrEmpty(enemyId) ? Guid.NewGuid().ToString() : enemyId;
            communicator = new SoldiersCommunicator();
        }

        /// <summary>
        /// Update is called once per frame 
        /// </summary>
        void Update()
        {
            
        }
    }
}