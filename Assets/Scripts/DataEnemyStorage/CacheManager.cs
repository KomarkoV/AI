using Assets.Scripts.DataEnemyStorage.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.DataEnemyStorage
{
    public class CacheManager
    {
        private Dictionary<CacheKey, ICacheLayer> cacheStructure;

        private static CacheManager instance;
        private CacheManager()
        {
            cacheStructure = new Dictionary<CacheKey, ICacheLayer>();
        }

        public static CacheManager GetInstance()
        {
            if (instance == null)
            {
                instance = new CacheManager();
            }
            return instance;
        }

        public void AddNewCacheLayer(CacheKey key, ICacheLayer layer)
        {
            if (!cacheStructure.ContainsKey(key))
            {
                cacheStructure.Add(key, layer);
            }
            else
            {

            }
        }
    }
}
