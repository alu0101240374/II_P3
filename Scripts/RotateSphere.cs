using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSphere : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform objective;

    void Start()
    {
      GameController.eventRotateSphere += rotateSphere;
    }

    void rotateSphere(Transform objectivePosition)
    {
        Debug.DrawRay(transform.position, transform.forward * 10, Color.red);
        transform.LookAt(objectivePosition);
    }
}
