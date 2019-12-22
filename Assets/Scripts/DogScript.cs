using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogScript : MonoBehaviour
{

    public Sprite[] Baloons;
    public float DogSpeed;
    public AudioSource PopSoundEffect;

    private int currentSprite = 0;
    private SpriteRenderer sprRen;
    private Rigidbody2D rigid2D;
    private bool movementLock = false;
    private float yAxis;

    // Use this for initialization
    void Start()
    {
        sprRen = gameObject.GetComponent<SpriteRenderer>();
        rigid2D = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (!movementLock)
        {
            yAxis = Input.GetAxisRaw("Vertical");
        }

        if (currentSprite == 6)
        {
            rigid2D.gravityScale = 1;
            movementLock = true;
            GameOverManager.isGameOver = true;
        }

        MoveDog(yAxis);
    }



    void OnTriggerEnter2D(Collider2D other)
    {
        currentSprite++;
        sprRen.sprite = Baloons[currentSprite];
        Destroy(other.gameObject);
        PopSoundEffect.Play();
    }

    private void MoveDog(float direction)
    {
        gameObject.transform.Translate(Vector3.up * DogSpeed * Time.deltaTime * direction);
    }
}