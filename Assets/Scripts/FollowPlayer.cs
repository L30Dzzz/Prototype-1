using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    // creates distance behind vehicle 
    private Vector3 offset = new Vector3(0, 5, -7);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    // Update is called once per frame, but has less priority
    void LateUpdate()
    {
        //follows vehicle
      transform.position = player.transform.position + offset; 
    }
}
