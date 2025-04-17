using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour
{
    [SerializeField]
    private string name;
    
    public virtual void Start()
    {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(() => { Select(); });
    }

    public virtual void Select()
    {
        Debug.Log($"Select your chosen Invincible character!");
    }
}
