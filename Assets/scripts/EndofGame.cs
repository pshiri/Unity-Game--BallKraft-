using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndofGame : MonoBehaviour
{
    public Canvas endofgame;


    void OnCollisionEnter(Collision col)
    {

        if (col.collider.tag == ("Player"))
        {

            endofgame.gameObject.SetActive(true);
            col.gameObject.SetActive(false);
        }
    }
} 
  