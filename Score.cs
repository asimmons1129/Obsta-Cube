using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public static int size;
    public Transform[] obstacle = new Transform[size];
    public Text scoreText;
    public static int score;

    void Start()
    {
        scoreText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score = 0;
        for (int i = 0; i < obstacle.Length; i++)
        {
            if (obstacle[i].position.z < player.position.z)
            {
                if (obstacle[i].tag == "Obstacle")
                {
                    obstacle[i].GetComponent<Renderer>().material.color = Color.red;
                    score++;
                    scoreText.text = score.ToString();
                }

            }

        }
    }
}
