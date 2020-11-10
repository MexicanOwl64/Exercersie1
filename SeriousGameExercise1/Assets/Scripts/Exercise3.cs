using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise3 : MonoBehaviour
{
   
    
    private Vector3 mousePosition;
    public float moveSpeed = 0.1f;
    private float num;
    private float x;
    private float y;
    
   

    // Update is called once per frame
    void Update()
    {    
        num = Random.Range(0f, 1f);

        if (num < .5f)
        {
            x++;
            y--;
            transform.position = new Vector2(x, y);
            Debug.Log("Object is moving");
        }
        else if (num > 0.6F)
        {
            x++;
            transform.position = new Vector2(x, y);
            Debug.Log("Object is moving");
        }
        else if (num > .8F)
        {
            y++;
            transform.position = new Vector2(x, y);
            Debug.Log("Object is moving");
        }
        else
        {            
            transform.position = new Vector2(x, y);
            Debug.Log("Object is not moving");
        }
        
    }
}


   
      

