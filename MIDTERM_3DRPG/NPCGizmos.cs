using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCGizmos : MonoBehaviour
{
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, 5f);

        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, 12f);

        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, 18f);
    }
}
