using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise6 : MonoBehaviour
{
    
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        float x = 0;
        float y = 0;

        float stepsize = Random.Range(0, 10);

        float stepx = Random.Range(-stepsize, stepsize);
        float stepy = Random.Range(-stepsize, stepsize);

        if (stepx == stepx * stepx && stepy == stepy * stepy)
        {
            x = stepx;
            y = stepy;
            transform.position = new Vector3(x, y, 0);
        }
        else
        {
            x = stepx;
            y = stepy;
            transform.position = new Vector3(x, y, 0);
        }
        transform.position = new Vector3(x, y, 0);
    }
}




    

    
    
    
   
       

        



       
        

    

