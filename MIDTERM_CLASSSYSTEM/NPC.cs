using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC : MonoBehaviour
{
    [SerializeField]
    private string name;
    public virtual void Start()
    {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(() => { Talk(); });
    }

    public virtual void Talk()
    {
        Message message = new Message(name, $"Hello, this is a Non-Playable Character");
        MessageManager.messageManager.UpdateMessage(message);
    }
}
