using Symbioz.Protocol.Enums;
using Symbioz.Protocol.Selfmade.Enums;
using Symbioz.World.Models.Effects;
using Symbioz.World.Models.Fights.Fighters;
using Symbioz.World.Models.Maps;
using Symbioz.World.Providers.Maps.Path;
using Symbioz.World.Records.Spells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Symbioz.World.Providers.Fights.Effects.Movements
{
    [SpellEffectHandler(EffectsEnum.Effect_PullForward)]
    public class PullForward : SpellEffectHandler
    {
        public PullForward(Fighter source, SpellLevelRecord spellLevel, EffectInstance effect,
           Fighter[] targets, MapPoint castPoint, bool critical)
            : base(source, spellLevel, effect, targets, castPoint, critical)
        {

        }
        public override bool Apply(Fighter[] targets)
        {

            foreach (Fighter target in targets)
            {
                target.Abilities.PullForward(Source, (short)Effect.DiceMin, CastPoint);
            }

            return true;
        }
    }
}