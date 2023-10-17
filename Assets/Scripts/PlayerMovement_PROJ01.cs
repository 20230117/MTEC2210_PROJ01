using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement_PROJ01 : MonoBehaviour
{
    public float movementSpeed = 5;
    public AudioSource SoundEffect;
    void Start()
    {
        
    }

    void Update()
    {
        float xInput = Input.GetAxisRaw("Horizontal");
        transform.Translate(movementSpeed * Time.deltaTime * xInput, 0, 0);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            SoundEffect.Play();
            ScoreManager_PROJ01.instance.AddPoint();
            Destroy(other.gameObject);
        }
 
        if(other.gameObject.CompareTag("Transition"))
        {
            SoundEffect.Play();
            Debug.Log("Theme Box collected.");
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("Hazard"))
        {
            SoundEffect.Play();
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}