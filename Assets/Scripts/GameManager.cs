using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    bool hasEnded = false;
    Boolean comp = false;
    public float delay;
    public GameObject congrats,offroad,collision;
    public Text congo_text,collide_text,offroad_text;
    public AudioSource fall_sound;

    void start()
    {
        fall_sound = GetComponent<AudioSource>();
    }

    public void EndGame_collision()
    {
        if (hasEnded == false && comp == false) {
            hasEnded = true;
            UnityEngine.Debug.Log("you collided ");
            collision.SetActive(true);
            collide_text.enabled = true;
            Invoke("Restart", delay);
        }
    }
   
    public void EndGame_offroad()
    {
        if (hasEnded == false && comp == false)
        {
            hasEnded = true;
            UnityEngine.Debug.Log("went off road ");
            offroad.SetActive(true);
            offroad_text.enabled = true;
            //fall_sound.Play();
            Invoke("Restart", delay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(0);
    }

    public void complete()
    {
        comp = true;
        congrats.SetActive(true);
        congo_text.enabled = true;
        UnityEngine.Debug.Log("Congoooo");
        //Invoke("Restart", delay);
        Invoke("NextLevel", delay);
    }

    public void NextLevel()
    {
        if (SceneManager.GetActiveScene().buildIndex != 2)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
