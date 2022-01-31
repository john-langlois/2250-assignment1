using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public  GameObject crystal;
    public Vector3 size;
    public Vector3 center;
    private ArrayList objectList = new ArrayList();
    // Start is called before the first frame update
    void Start()

    {
        createEnemy(8);
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0f, 100f, 0f) * Time.deltaTime);
    }
    
    public void createEnemy(int enemyNum)
    {
        for(int i = 0; i < enemyNum; i++)
        {
            GameObject enemyClone = Instantiate(crystal, new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.z / 2)), Quaternion.identity);
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawCube(center, size);
    }
}
