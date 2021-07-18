using UnityEngine;

public class Collide : MonoBehaviour
{
    public Forward f;
    bool hasEnded = false;
    public AudioSource sound;

    void Start()
    {
        sound = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(UnityEngine.Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle" && hasEnded == false)
        {
            f.enabled = false;
            hasEnded = true;
            //UnityEngine.Debug.Log("Shit");
            sound.Play();
            FindObjectOfType<GameManager>().EndGame_collision();


        }
        //UnityEngine.Debug.Log(collisionInfo.collider.name);
    }
}
