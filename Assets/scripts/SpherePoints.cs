using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpherePoints : MonoBehaviour
{
    public Canvas scoretext;
    public Canvas enemytext;
    public Canvas gameover;
    public Canvas endofgame;


    void OnCollisionEnter(Collision col)
    {
        void Start()
        {
        }

        if(col.collider.tag == ("score"))
        {

            this.GetComponent<AudioSource>().Play();
            scoretext.gameObject.SetActive(true);
            StartCoroutine("WaitForSec");
            KeepScore.Score += 100;
            Debug.Log("PLayed Sound!");
            Destroy(col.gameObject);
        }
        
        if (col.collider.tag == ("enemy"))
        {
            enemytext.gameObject.SetActive(true);
            StartCoroutine("WaitForSec");
            if (KeepScore.Score == 0)
            {
                GameObject.FindWithTag("Player").SetActive(false);
                gameover.gameObject.SetActive(true);
                Destroy(col.gameObject);
            }
            else
            {
                KeepScore.Score -= 100;
                Destroy(col.gameObject);
            }
        }

        if (col.collider.tag == ("endofgame"))
        {

            this.GetComponent<AudioSource>().Play();
            endofgame.gameObject.SetActive(true);
            StartCoroutine("WaitForSec");
            Destroy(col.gameObject);
        }


    }

    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(0.4f);
        scoretext.gameObject.SetActive(false);
        enemytext.gameObject.SetActive(false);

    }

} 
    
