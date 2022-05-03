using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class ListofObjects : MonoBehaviour
{
    public List<GameObject> objects = new List<GameObject>();
    
    void OnCollisionEnter(Collision col)

    {

        if (col.gameObject.name == ("Cube (1)"))
        {
            objects.Add(col.gameObject);
            Debug.Log(objects.ToString());
        }
        if (col.gameObject.name == ("Cube (5)"))
        {
            objects.Add(col.gameObject);
        }
    }

}

