using SSync.IO;
using SSync.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Symbioz.Protocol.Selfmade.Messages
{
    public class BanRequestMessage : TransitionMessage
    {
        public const ushort Id = 6712;

        public override ushort MessageId
        {
            get
            {
                return Id; ;
            }
        }

        public int AccountId;

        public BanRequestMessage(int accountId)
        {
            this.AccountId = accountId;
        }
        public BanRequestMessage()
        {

        }

        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteInt(AccountId);
        }

        public override void Deserialize(ICustomDataInput reader)
        {
            this.AccountId = reader.ReadInt();
        }

    }
}
