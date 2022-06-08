using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.Builder
{
    /// <summary>
    /// 面包建造器 ： 具体建造者
    /// </summary>
    public class BreadBuilder : ActorBuilder
    {
        public override void BuildCostume()
        {
            actor.Costume = "一个有个性的盔甲";
        }

        public override void BuildFace()
        {
            actor.Face = "靓仔";
        }

        public override void BuildHairStyle()
        {
            actor.HairStyle = "爆炸头";
        }

        public override void BuildSex()
        {
            actor.Sex = "男";
        }

        public override void BuildType()
        {
            actor.Type = "面包";
        }
    }
}
