using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed;
    [SerializeField] float moveSpeed;
    [SerializeField] float slowSpeed;
    [SerializeField] float normalSpeed;
    [SerializeField] float boostSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float steerMotion = steerSpeed * Input.GetAxis("Horizontal") * Time.deltaTime;
        float moveMotion = moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime;

        transform.Rotate(0.0f, 0.0f, -steerMotion);
        transform.Translate(0.0f, moveMotion, 0.0f);

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Obstacle")
        {
            moveSpeed = slowSpeed;
        }    
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Boost")
        {
            if(moveSpeed == slowSpeed)
            {
                moveSpeed = normalSpeed;
            }
            else
            {
                moveSpeed = boostSpeed;
            }
        }

        if (collision.tag == "Secret")
        {
            ScenesManager.LoadSecretScene();
        }
    }
}
