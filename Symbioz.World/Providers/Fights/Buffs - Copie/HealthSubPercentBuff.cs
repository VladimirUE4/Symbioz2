using Symbioz.Protocol.Selfmade.Enums;
using Symbioz.Protocol.Types;
using Symbioz.World.Models.Effects;
using Symbioz.World.Models.Fights.Fighters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Symbioz.World.Providers.Fights.Buffs
{
   public class HealthSubPercentBuff : Buff
    {
         public override ushort ActionId
        {
            get
            {
                return (ushort)ActionsEnum.ACTION_CHARACTER_DEBOOST_VITALITY;
            }
        }
        public HealthSubPercentBuff(Fighter source, Fighter target, short delta,
           EffectInstance effect, ushort spellId)
            : base(source, target, delta, effect, spellId)
        {

        }
        public override void Apply()
        {
            Target.Stats.CurrentLifePoints -= Delta;
            base.Apply();
        }

        public override void Dispell()
        {
            Target.Stats.CurrentLifePoints += Delta;
        }

    }
}
