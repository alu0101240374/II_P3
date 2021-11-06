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
        transform.LookAt(objectivePosition);
    }
}
