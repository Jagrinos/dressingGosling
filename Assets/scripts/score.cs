using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class score : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] float speedScorePoints;
    float scorePoints = 0;
    int fullScore;
    void Start()
    {
        fullScore = Random.Range(0, 10000);
    }
    void Update()
    {
        if (scorePoints < fullScore)
            scorePoints += Time.deltaTime * speedScorePoints;
        scoreText.text = "Î×ÊÈ: " + scorePoints.ToString();
    }

    public void back()
    {
        Destroy(GameObject.FindWithTag("gosl"));
        SceneManager.LoadScene("main", LoadSceneMode.Single);
    }
}
