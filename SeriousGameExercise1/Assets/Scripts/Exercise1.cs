using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise1 : MonoBehaviour
{
    
    introMover walker;

    
    void Start()
    {
        walker = new introMover();
    }

    
    void FixedUpdate()
    {        
        walker.step();
        walker.CheckEdges();
    }
}


public class introMover
{
    
    private Vector3 location;


    private Vector2 minimumPos, maximumPos;

  
    public GameObject mover = GameObject.CreatePrimitive(PrimitiveType.Sphere);

    public introMover()
    {
        findWindowLimits();
        location = Vector2.zero;
        Renderer r = mover.GetComponent<Renderer>();
        r.material = new Material(Shader.Find("Diffuse"));
    }

    public void step()
    {
        location = mover.transform.position;

        location.x--;
        location.y--;
 
        mover.transform.position += location * Time.deltaTime;
    }

    public void CheckEdges()
    {
        location = mover.transform.position;

        if (location.x > maximumPos.x)
        {
            location = Vector2.zero;
        }
        else if (location.x < minimumPos.x)
        {
            location = Vector2.zero;
        }
        if (location.y > maximumPos.y)
        {
            location = Vector2.zero;
        }
        else if (location.y < minimumPos.y)
        {
            location = Vector2.zero;
        }
        mover.transform.position = location;
    }

    private void findWindowLimits()
    {      
        Camera.main.orthographic = true;
        minimumPos = Camera.main.ScreenToWorldPoint(Vector2.zero);
        maximumPos = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
    }
}
