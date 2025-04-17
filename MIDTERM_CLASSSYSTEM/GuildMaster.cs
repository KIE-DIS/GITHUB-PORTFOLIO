using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuildMaster : NPC
{
    public override void Start()
    {
        name = "John";
        base.Start();
    }

    public override void Talk()
    {
        Message message = new Message(name, $"Hello, this is {name}, how may I help you?");
        MessageManager.messageManager.UpdateMessage(message);
    }
}
