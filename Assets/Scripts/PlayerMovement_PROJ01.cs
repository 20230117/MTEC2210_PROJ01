using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using TMPro;

public class PlayerMovement_PROJ01 : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip coinSound;
    public float MovementSpeed = 150;
    Rigidbody2D rb;
    float xMove;
    float yMove;
    //public TextMeshPro playerScoreText;
    int playerScore;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()   
    {
        //playerScoreText.text = playerScore.ToString();

        xMove = Input.GetAxisRaw("Horizontal");
    }

    public void IncrementScore(int scoreChange)
    {
        playerScore += scoreChange;
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(xMove, yMove) * Time.deltaTime * MovementSpeed;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            int value = collision.gameObject.GetComponent<CoinScript_PROJ01>().coinValue; //this is the player, we know this because the code wouldn't run otherwise.
            IncrementScore(value);

            audioSource.PlayOneShot(coinSound);

            Destroy(collision.gameObject);
        }

    }
}
