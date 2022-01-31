using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoringSystem : MonoBehaviour
{
    public GameObject scoreText;
    public int scoreValue;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("crystal"))
        {
            scoreValue += 10;
            scoreText.GetComponent<Text>().text = "SCORE: " + scoreValue;

        }
        
    }
}
