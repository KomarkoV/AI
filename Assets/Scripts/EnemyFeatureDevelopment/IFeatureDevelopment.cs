using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.EnemyFeatureDevelopment
{
    public interface IFeatureDevelopment
    {
        List<string> DevelopableFeatures { get; set; }
        void IncreaseFeature<T>(T featureValue, string featureName) where T : struct;
        void CheckDependencyOfFeatureIncrease<T>(T featureValue, string featureName) where T : struct;
    }
}
