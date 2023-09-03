using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Paddlemovement : MonoBehaviour
{

    Rigidbody2D rb;
    public float speed = 13.5f;
    [SerializeField]private 
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal")*speed,0f);
    }
}