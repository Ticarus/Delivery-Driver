using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Sprite hasPackageSprite;
    [SerializeField] Sprite noPackageSprite;

    [SerializeField] float timeToDestroy = 0.5f;
    [SerializeField] int remainingDelivery;
    bool hasPackage;

    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        remainingDelivery = GameObject.FindGameObjectsWithTag("Delivery").Length;
    }
    void OnCollisionEnter2D(Collision2D collider)
    {
        Debug.Log("Oops!");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Pickup" && !hasPackage)
        {
            Debug.Log("Package pickup successful");
            hasPackage = true;
            spriteRenderer.sprite = hasPackageSprite;
        }
        
        if(collision.tag == "Delivery" && hasPackage)
        {
            Debug.Log("Package delivered");
            hasPackage = false;
            Destroy(collision.gameObject, timeToDestroy);
            spriteRenderer.sprite = noPackageSprite;
            remainingDelivery--;
        }

        if(remainingDelivery == 0)
        {
            ScenesManager.LoadNextScene();
        }
    }
}
