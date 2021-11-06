using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    
    public delegate void CollisionAMethodDelegate();
    public static event CollisionAMethodDelegate eventCollisionA;

    public delegate void ChangeColorMethodDelegate();
    public static event ChangeColorMethodDelegate eventChangeColor;

    public delegate void RotateSphereMethodDelegate(Transform position);
    public static event RotateSphereMethodDelegate eventRotateSphere;

    public delegate void CollisionBMethodDelegate();
    public static event CollisionBMethodDelegate eventCollisionB;

    public static GameController controller;

    void Awake() 
    {
        if (controller == null)
        {
          controller = this;
          DontDestroyOnLoad(this);
        } else if (controller != this)
        {
            Destroy(gameObject);
        }
    }

    public void collisionWithA()
    {
      eventCollisionA();
    }

    public void changeBColor()
    {
      eventChangeColor();
    }

    public void rotateSphere(Transform position)
    {
      eventRotateSphere(position);
    }

    public void collisionWithB()
    {
      eventCollisionB();
    }
}
