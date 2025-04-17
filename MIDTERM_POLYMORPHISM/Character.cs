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
        button.onClick.AddListener(() => { Choose(); });
    }

    public virtual void Choose()
    {
        Debug.Log($"Choose your favorite hero...or villain!");
    }
}
