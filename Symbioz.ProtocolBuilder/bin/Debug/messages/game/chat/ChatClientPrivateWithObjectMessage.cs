


















using System;
using System.Collections.Generic;
using System.Linq;
using Symbioz.Protocol.Types;
using SSync.IO;
using SSync.Messages;

namespace Symbioz.Protocol.Messages
{

public class ChatClientPrivateWithObjectMessage : ChatClientPrivateMessage
{

public const ushort Id = 852;
public override ushort MessageId
{
    get { return Id; }
}

public Types.ObjectItem[] objects;
        

public ChatClientPrivateWithObjectMessage()
{
}

public ChatClientPrivateWithObjectMessage(string content, string receiver, Types.ObjectItem[] objects)
         : base(content, receiver)
        {
            this.objects = objects;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteUShort((ushort)objects.Length);
            foreach (var entry in objects)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            var limit = reader.ReadUShort();
            objects = new Types.ObjectItem[limit];
            for (int i = 0; i < limit; i++)
            {
                 objects[i] = new Types.ObjectItem();
                 objects[i].Deserialize(reader);
            }
            

}


}


}