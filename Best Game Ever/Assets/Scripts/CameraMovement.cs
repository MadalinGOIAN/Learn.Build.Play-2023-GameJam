using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 0, -10f);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Keep the camera in the same position as the player
        transform.position = player.transform.position + offset;
    }
}
