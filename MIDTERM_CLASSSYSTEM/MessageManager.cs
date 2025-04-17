using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MessageManager : MonoBehaviour
{
    public static MessageManager messageManager;
    public TextMeshProUGUI dialogText;
    public TextMeshProUGUI nameText;

    public void Awake()
    {
        if (messageManager == null)
        {
            messageManager = this;
        }
        else
        {
            Destroy(this);
        }
    }

    public void UpdateMessage(Message message)
    {
        dialogText.text = message.text;
        nameText.text = message.name;
    }
}
