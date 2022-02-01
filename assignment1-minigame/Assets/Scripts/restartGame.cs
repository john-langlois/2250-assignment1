using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartGame : MonoBehaviour
{
    private Scene scene;
    public scoringSystem scoring;
    public PlayerMovement player;
    private GameObject[] crystals;
    private Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        crystals = GameObject.FindGameObjectsWithTag("crystal");
        startPos = player.rb.position;
        scene = SceneManager.GetActiveScene();
        
    }

    // Update is called once per frame
    void Update()
    {
       if(scoring.count == 8)
        {
            Invoke("Restart", 2.0f);
        }
        
    }
     void Restart()
    {
       
        scoring.scoreValue = 0;

        for(int i = 0; i < crystals.Length; i++)
        {
            crystals[i].gameObject.SetActive(true);
        }

        player.rb.position = startPos;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
