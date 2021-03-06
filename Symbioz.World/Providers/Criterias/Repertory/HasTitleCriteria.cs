using Symbioz.World.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Symbioz.World.Providers.Criterias.Repertory
{
    [Criteria("TL")]
    public class HasTitleCriteria : AbstractCriteria
    {
        public override bool Eval(WorldClient client)
        {
            bool obj = client.Character.HasTitle(ushort.Parse(CriteriaValue));

            return ComparaisonSymbol == '=' ? obj : !obj;
        }
    }
}
