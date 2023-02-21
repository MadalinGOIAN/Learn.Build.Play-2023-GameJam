using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5.0f;      // !de stabilit o valoare pentru joc!
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }

    void Movement(float horizontalInput, float verticalInput)
    {
        // Movement folosind butoane
        transform.Translate(Vector2.right * Time.deltaTime * horizontalInput * speed);      // axa verticala ( tastele W,S )
        transform.Translate(Vector2.up * Time.deltaTime * verticalInput * speed);           // axa orizontala ( tastele A,D )
    }
}
