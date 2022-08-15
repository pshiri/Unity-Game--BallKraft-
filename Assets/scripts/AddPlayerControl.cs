using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPlayerControl : MonoBehaviour
{
    [SerializeField]
    Vector3 v3Force;
    [SerializeField]
    KeyCode KeyPositive;
    [SerializeField]
    KeyCode KeyNegative;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                // Insert Code Here (I.E. Load Scene, Etc)
                Application.Quit();

                return;
            }
        }
        else 
        {
            if (Input.GetKey(KeyPositive))
            { GetComponent<Rigidbody>().velocity += v3Force; }
            if (Input.GetKey(KeyNegative))
            {
                GetComponent<Rigidbody>().velocity -= v3Force;
            }
                }
    }
}
