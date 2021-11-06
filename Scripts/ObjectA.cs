using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectA : MonoBehaviour
{
    public float detectionDistance = 0f;

    private float timer = 0f;

    void Start()
    {
        GameController.eventCollisionB += CollisionMessage; 
    }

    void FixedUpdate()
    {
        timer += Time.fixedDeltaTime;
        Transform player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        float distanceBetweenObject = Vector3.Distance(player.position, transform.position);
        if (distanceBetweenObject < detectionDistance)
        {
            if (timer >= 1.0f) 
            {
                GameController.controller.changeBColor();
                timer = 0;
            }
            GameController.controller.rotateSphere(player);
        }
    }

    void CollisionMessage()
    {
        Text text = GameObject.FindGameObjectWithTag("Text").GetComponent<Text>();
        text.text = "A: has colisionado con el objeto B";
    }

    void OnCollisionEnter(Collision other)
    {
      if (other.gameObject.tag == "Player") 
      {
          GameController.controller.collisionWithA();
      }
    }
}
