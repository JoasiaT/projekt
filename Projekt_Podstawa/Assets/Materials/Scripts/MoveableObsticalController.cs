using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveableObsticalController : MonoBehaviour
{
    public Transform startPoint;
    public Transform endPoint;
    public bool isMovingRight = true;
    public int speed = 1;


    // Update is called once per frame
    void Update()
    {
       if (isMovingRight)
       {
          transform.Translate(speed * Time.deltaTime, 0, 0);
           if (transform.position.x > endPoint.position.x)
          {
              isMovingRight = false;
           }
        }
        else
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
            if (transform.position.x < startPoint.position.x)
            {
               isMovingRight = true;
            }
        }
    }
}
