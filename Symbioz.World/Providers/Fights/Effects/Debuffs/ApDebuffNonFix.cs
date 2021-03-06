using Symbioz.Protocol.Enums;
using Symbioz.Protocol.Selfmade.Enums;
using Symbioz.World.Models.Effects;
using Symbioz.World.Models.Fights.Fighters;
using Symbioz.World.Models.Maps;
using Symbioz.World.Records.Spells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Symbioz.World.Providers.Fights.Effects.Debuffs
{
    [SpellEffectHandler(EffectsEnum.Effect_LosingAP)]
    [SpellEffectHandler(EffectsEnum.Effect_RemoveAP)]
    [SpellEffectHandler(EffectsEnum.Effect_SubAp_1079)] // Maladresse de Masse de l'énutrof
    public class ApDebuffNonFix : SpellEffectHandler
    {
        public ApDebuffNonFix(Fighter source, SpellLevelRecord spellLevel, EffectInstance effect,
              Fighter[] targets, MapPoint castPoint, bool critical)
            : base(source, spellLevel, effect, targets, castPoint, critical)
        {

        }
        public override bool Apply(Fighter[] targets)
        {
            foreach (var target in targets)
            {
                int num = 0;
                int num2 = 0;

                while (num2 < (int)Effect.DiceMin && num < target.Stats.ActionPoints.TotalInContext())
                {
                    if (target.RollApLose(Source))
                    {
                        num += 1;
                    }
                    num2++;
                }
                short num3 = (short)(Effect.DiceMin - num);
                if (num3 > 0)
                {
                    target.OnDodgePointLoss(ActionsEnum.ACTION_FIGHT_SPELL_DODGED_PA, Source, (ushort)num3);
                }
                if (num <= 0)
                {
                    return false;
                }

                if (this.Effect.Duration > 1)
                {
                    base.AddStatBuff(target, (short)-num, target.Stats.ActionPoints, FightDispellableEnum.DISPELLABLE);
                }
                else
                {
                    target.LostAp(Source.Id, (short)num);
                }
            }
            return true;
        }
    }
}
