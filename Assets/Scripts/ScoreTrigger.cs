using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreTrigger : MonoBehaviour
{
    int score = 0;
    public TextMeshProUGUI ScoreText;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            score++;
        Debug.Log(score);
        ScoreText.text = score.ToString() + " points";
    }
}
