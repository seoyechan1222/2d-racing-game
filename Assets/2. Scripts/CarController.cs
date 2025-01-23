using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CarController : MonoBehaviour
{
    public Canvas RestartMenu;
    private Rigidbody2D rb;
    
    public float moveSpeed = 1.0f;
    private float direction;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Time.timeScale = 0;
        RestartMenu.gameObject.SetActive(true);
        Destroy(gameObject);
       
    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        direction = Input.GetAxisRaw("Horizontal");
        

    }
    private void FixedUpdate()
    {
        rb.velocity = Vector2.zero;
        rb.velocity = new Vector2(direction * Time.fixedTime * moveSpeed, 0);
    }
}