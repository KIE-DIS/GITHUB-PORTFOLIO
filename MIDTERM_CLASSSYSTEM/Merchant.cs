using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Merchant : NPC
{
    public override void Start()
    {
        name = "Kelly";
        base.Start();
    }

    public override void Talk()
    {
        Message message = new Message(name, $"Hello, this is {name}, how can I help you?");
        MessageManager.messageManager.UpdateMessage(message);
    }
}
