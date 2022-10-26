using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpperScoreTrigger : MonoBehaviour
{
    public TextMeshProUGUI UpperScoreText;
    int UpperScore = 0;
    //public UpperScoreText.SetText(UpperScore.ToString()
  
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            UpperScore++;
        Debug.Log(UpperScore);
        UpperScoreText.text = UpperScore.ToString() + " Roof Touches";
    }
    void Update()
    {
 
    }
}
