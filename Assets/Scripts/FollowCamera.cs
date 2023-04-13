using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject car;

    // Update is called once per frame
    void LateUpdate()
    {

        // camera position should be the same as car position
        transform.position = car.transform.position + new Vector3(0, 0, -10);
    }
}
