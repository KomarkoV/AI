using Assets.Scripts.Communication;
using Assets.Scripts.EnemyFeatureDevelopment;
using Assets.Scripts.EnemySoldiers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Scripts.EnemyHQ
{
    public class EnemyHqUnit : MonoBehaviour
    {
        
        private string hqUnitId;
        private DateTimeOffset lastArmySpawnDate;
        private ICommunicator communicator;       
        private HqUnitFeatures hqUnitFeatures;
        private IFeatureDevelopment featureDevelopment;

        [SerializeField]
        private Transform soldiersSpawnPlace;
        [SerializeField]
        private GameObject[] enemySoldiers;

        /// <summary>
        /// Enemy sub army
        /// </summary>
        public GameObject[] EnemySoldiers
        {
            get { return enemySoldiers; }
            set { enemySoldiers = value; }
        }

        public Transform SoldiersSpawnPlace
        {
            get { return soldiersSpawnPlace; }
            set { soldiersSpawnPlace = value; }
        }

        /// <summary>
        /// Use this for initialization
        /// </summary>
        private void Start()
        {
            hqUnitFeatures = GetComponent(nameof(HqUnitFeatures)) as HqUnitFeatures;
            hqUnitId = string.IsNullOrEmpty(hqUnitId) ? Guid.NewGuid().ToString() : hqUnitId;
            if (!soldiersSpawnPlace)
            {
                soldiersSpawnPlace = this.transform;
            }

            CreateNewEnemy(soldiersSpawnPlace);
        }

        /// <summary>
        /// Update is called once per frame
        /// </summary>
        private void Update()
        {
            if (featureDevelopment.IsShouldDevelopFeatures())
            {
                //featureDevelopment.IncreaseFeature()
            }

            if (enemySoldiers.Length > 0 && enemySoldiers.Any(x => x == null) && CanCreateNewSoldiers())
            {
                CreateNewEnemy(soldiersSpawnPlace);                
            }
        }

        private bool CanCreateNewSoldiers()
        {
            return lastArmySpawnDate.AddSeconds(hqUnitFeatures.ArmySpawnInterval) < DateTimeOffset.Now;
        }

        private void CreateNewEnemy(Transform spawnPoint, float maxHealth = 100, float rangeOfView = 50)
        {
            float x = spawnPoint.position.x;
            float z = spawnPoint.position.z;
            for (int i = 0; i < enemySoldiers.Length; i++)
            {
                if (enemySoldiers[i] == null)
                {
                    
                    enemySoldiers[i] = Instantiate(Resources.Load(ResourceConstants.EnemyPrefab)) as GameObject;
                    enemySoldiers[i].SetActive(false);
                    enemySoldiers[i].transform.localPosition = new Vector3(x, spawnPoint.position.y, z);
                    x++;
                    z++;
                    var enemySoldier = enemySoldiers[i].GetComponent(nameof(EnemySoldier)) as EnemySoldier;
                    enemySoldier.HqUnitId = hqUnitId;
                    enemySoldier.SoldierFeatures.MaxTechnicalCondition = maxHealth;
                    enemySoldier.SoldierFeatures.CurrentTechnicalCondition = maxHealth;
                    enemySoldier.SoldierFeatures.RangeOfView = rangeOfView;
                    lastArmySpawnDate = DateTimeOffset.Now;
                }
            }        
        }
    }
}