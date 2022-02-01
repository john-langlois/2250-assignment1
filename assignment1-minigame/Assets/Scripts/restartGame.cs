using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartGame : MonoBehaviour
{
    private Scene scene;
    public scoringSystem scoring;
    public PlayerMovement player;
    private GameObject[] crystals,golds,silvers;
    private Vector3 startPos;
    public int endScore;

    // Start is called before the first frame update
    void Start()
    {
        crystals = GameObject.FindGameObjectsWithTag("crystal");
        golds = GameObject.FindGameObjectsWithTag("gold");
        silvers= GameObject.FindGameObjectsWithTag("silver");

        startPos = player.rb.position;
        scene = SceneManager.GetActiveScene();
        
    }

    // Update is called once per frame
    void Update()
    {
       if(scoring.count == endScore)
        {
            Invoke("Restart", 1.0f);
        }
        
    }
     void Restart()
    {
       
        scoring.scoreValue = 0;
        //Sets all purple crystals back to original position
        for(int i = 0; i < crystals.Length; i++)
        {
            crystals[i].gameObject.SetActive(true);
        }

        //sets all gold crystals back to original position
        for (int i = 0; i < golds.Length; i++)
        {
            golds[i].gameObject.SetActive(true);
        }

        //sets all silver crystals back to original position
        for (int i = 0; i < silvers.Length; i++)
        {
            silvers[i].gameObject.SetActive(true);
        }

        player.rb.position = startPos;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
