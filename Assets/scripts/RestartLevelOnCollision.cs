using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevelOnCollision : MonoBehaviour
{
    [SerializeField]
    string strTag;

    public Canvas EscCan;


    private void OnCollisionEnter(Collision collision)
    {


        if (collision.collider.tag == strTag)
            EscCan.gameObject.SetActive(true);


        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        if (collision.gameObject.name == ("Player"))
        {
            collision.gameObject.SetActive(false);
            //KeepScore.Score = 0;
        }
    }
}
