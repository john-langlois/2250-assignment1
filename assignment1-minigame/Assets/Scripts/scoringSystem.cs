using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoringSystem : MonoBehaviour
{
    public GameObject scoreText;
    public int scoreValue;
    public int count;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("crystal"))
        {
            scoreValue += 10;
            count+=1;
            scoreText.GetComponent<Text>().text = "SCORE: " + scoreValue;
            
        }
        
    }
}
