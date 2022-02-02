using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float moveSpeed = 7f;
    public SpawnObject spawn;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        float hInput = Input.GetAxis("Horizontal");
        float vInput = Input.GetAxis("Vertical");

        rb.velocity = new Vector3(hInput * moveSpeed, rb.velocity.y, vInput * moveSpeed);

    }

    void OnTriggerEnter(Collider other)
    {
        //if collides with crystal of each of thes tags it will make
        //it disappear
        if (other.gameObject.CompareTag("crystal"))
        {
            other.gameObject.SetActive(false);
        }
        //gold crystal
        if (other.gameObject.CompareTag("gold"))
        {
            other.gameObject.SetActive(false);
        }
        //silver crystal
        if (other.gameObject.CompareTag("silver"))
        {
            other.gameObject.SetActive(false);
        }
    }
}
