using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.EnemyFeatureDevelopment
{
    public interface IFeatureDevelopment
    {
        List<string> DevelopableFeatures { get; }       
        Dictionary<string, DateTimeOffset> LastDevelopments { get; set; }

        void IncreaseConcreteFeature(string featureName);
        void IncreaseFeatures(IFeatures features);
        void CheckDependencyOfFeatureIncrease<T>(T featureValue, string featureName) where T : struct;
        bool IsShouldDevelopFeatures();

    }
}
