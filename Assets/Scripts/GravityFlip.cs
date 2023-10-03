
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityFlip : MonoBehaviour
{
    public Rigidbody2D avatarRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            //setting gravity to opposite (up)
            avatarRigidbody.gravityScale *= -1;
            //saving the current scale to variable newDirection
            Vector3 newDirection = transform.localScale;
            //changing the y property of the newDirection variable
            newDirection.y *= -1;
            //giving the new scale property with the changed Y scale to the character
            gameObject.transform.localScale = newDirection;
        }
    }
}
