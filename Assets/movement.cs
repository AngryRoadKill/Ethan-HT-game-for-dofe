using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float jumpstrength;
    public Logicman logic;
    public bool PlayerAlive = true;
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logicman>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && PlayerAlive == true)
        {
            myRigidbody.velocity = Vector2.up * jumpstrength;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (PlayerAlive == true)
        {
            logic.gameOver();
            PlayerAlive = false;
            audioSource.Play();
            
        }
    }
}
