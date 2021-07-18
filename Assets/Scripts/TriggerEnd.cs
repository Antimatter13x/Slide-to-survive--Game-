using UnityEngine;

public class TriggerEnd : MonoBehaviour
{
    //public GameManager gameManager;

    void OnCollisionEnter(UnityEngine.Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Finish")
        {
            // UnityEngine.Debug.Log("Shit");
            FindObjectOfType<GameManager>().complete();


        }
        //UnityEngine.Debug.Log(collisionInfo.collider.name);
    }
}