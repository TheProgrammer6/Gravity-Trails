using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float  maximumXposition = 32f;
    public float minimumXposition = -32f;
    public float yForce;
    public float xForce;
    private Rigidbody2D enemyRigidBody;
    public float speed=5;
    public float xDirection;

    // Start is called before the first frame update
    void Start()
    {
        enemyRigidBody = GetComponent<Rigidbody2D>();
        xDirection = 1;
        enemyRigidBody.AddForce(Vector3.right * xForce);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       
        if(transform.position.x <= minimumXposition)
        {
            xDirection = 1;
            
        }

        if(transform.position.x >= maximumXposition)
        {
            xDirection =-1;
            
        }
        transform.position= transform.position + new Vector3(xDirection*speed*Time.deltaTime, 0,0);
          
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            xDirection = -1 * xDirection;
            Vector2 jumpForce = new Vector2(xDirection , yForce);
            enemyRigidBody.AddForce(jumpForce);
        }
         if (collision.gameObject.tag == "newys")
        {
         Destroy( gameObject);
        }
    }
}
