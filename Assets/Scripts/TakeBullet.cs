using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeBullet : MonoBehaviour
{
    public void OnTriggerEnter(Collider obj)
    {
        if (obj.CompareTag("Player")) 
        {
            obj.GetComponent<Player>().TakeBullet();
            Destroy(this.gameObject);
        }
    }
}
