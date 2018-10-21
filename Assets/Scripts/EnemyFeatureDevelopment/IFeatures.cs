using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.EnemyFeatureDevelopment
{
    public interface IFeatures
    {
        double FeatureDevelopmentInterval { get; set; }
        float CurrentTechnicalCondition { get; set; }
        float MaxTechnicalCondition { get; set; }
    }
}
