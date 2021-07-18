using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;


    void Update()
    {
            float score = player.position.z + 292.0f;
            scoreText.text = score.ToString("0");
    }
}
