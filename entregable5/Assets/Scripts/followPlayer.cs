using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(32, 0, 25);
 


    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
