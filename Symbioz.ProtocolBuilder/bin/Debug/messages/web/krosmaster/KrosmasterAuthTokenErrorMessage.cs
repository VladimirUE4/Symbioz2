


















using System;
using System.Collections.Generic;
using System.Linq;
using Symbioz.Protocol.Types;
using SSync.IO;
using SSync.Messages;

namespace Symbioz.Protocol.Messages
{

public class KrosmasterAuthTokenErrorMessage : Message
{

public const ushort Id = 6345;
public override ushort MessageId
{
    get { return Id; }
}

public sbyte reason;
        

public KrosmasterAuthTokenErrorMessage()
{
}

public KrosmasterAuthTokenErrorMessage(sbyte reason)
        {
            this.reason = reason;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteSByte(reason);
            

}

public override void Deserialize(ICustomDataInput reader)
{

reason = reader.ReadSByte();
            if (reason < 0)
                throw new Exception("Forbidden value on reason = " + reason + ", it doesn't respect the following condition : reason < 0");
            

}


}


}