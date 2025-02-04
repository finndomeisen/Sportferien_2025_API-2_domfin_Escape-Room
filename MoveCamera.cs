using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{

    public Transform cameraPosiotion;

    private void Update()
    {
        transform.position = cameraPosiotion.position;
    }

}
