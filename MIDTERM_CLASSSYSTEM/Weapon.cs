using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Weapon : MonoBehaviour
{
    [SerializeField]
    private string name;
    
    public virtual void Start()
    {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(() => { Attack(); });
    }

    public virtual void Attack()
    {
        Message message = new Message(name, $"This is a base class.");
        MessageManager.messageManager.UpdateMessage(message);
        Debug.Log($"The enemy has been struck by {name}!");
    }
}
