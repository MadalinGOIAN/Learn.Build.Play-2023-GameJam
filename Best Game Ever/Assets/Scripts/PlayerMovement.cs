using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.XR;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5.0f;      // !de stabilit o valoare pentru joc!
    public bool isWithinMapBounds = true;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isWithinMapBounds)
            Movement(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        else
            Fall();
    }

    void Movement(float horizontalInput, float verticalInput)
    {
        // Movement folosind butoane
        transform.Translate(Vector2.right * Time.deltaTime * horizontalInput * speed);      // axa orizontala ( tastele W,S )
        transform.Translate(Vector2.up * Time.deltaTime * verticalInput * speed);           // axa verticala ( tastele A,D )
    }

    void Fall()
    {
        transform.Translate(Vector2.down * Time.deltaTime * speed);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Map Bounds"))
            isWithinMapBounds = false;
    }
}
