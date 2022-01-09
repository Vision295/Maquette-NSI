using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public GameObject player;
    private Vector3 camPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        camPos = new Vector3(player.transform.position.x, 5, player.transform.position.z - 3);
        transform.position = camPos;
    }
}
