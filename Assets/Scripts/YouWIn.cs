using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YouWIn : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<PlayerController>())
        {
            GameManager.instance.Win();
        }
    }
}
