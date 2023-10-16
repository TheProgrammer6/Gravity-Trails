using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed;
    public Throwable direction;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyThrowable" , 5.0f);
        direction = GameObject.FindGameObjectWithTag("Player").GetComponent<Throwable>();
    }

    // Update is called once per frame
    void Update()
    {
      
       transform.position +=direction.offset * Time.deltaTime * speed; 
    }
    private void DestroyThrowable()
    {
        
        Destroy(gameObject);
        
    }
}
