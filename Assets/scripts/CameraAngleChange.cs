using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAngleChange : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == ("Player"))
        {

            //oldAngle = Quaternion.Euler(Camera.main.transform.localRotation.eulerAngles);
            //target = Quaternioin.Euler(0, 90, 0);

            Camera.main.transform.rotation = Quaternion.Slerp(Quaternion.Euler(Camera.main.transform.localRotation.eulerAngles), Quaternion.Euler(10, 0, 0), 1f);
        }
    }
}


