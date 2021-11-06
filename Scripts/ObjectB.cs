using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectB : MonoBehaviour
{
    void Start()
    {
        GameController.eventCollisionA += addForce;
        GameController.eventChangeColor += ChangeColor;        
    }

    void addForce()
    {
        PushScript.force += 1000;
    }

    void ChangeColor()
    {
        Color newColor = new Color(Random.value, Random.value, Random.value, 1.0f);
        GetComponent<Renderer>().material.color = newColor;
    }

    void OnCollisionEnter(Collision other)
    {
      if (other.gameObject.tag == "Player") {
        GameController.controller.collisionWithB();
      }
    }
}