using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2D : MonoBehaviour
{

    public float moveSpeed = 100f;

    float horizontalMove = 0f;

    public Animator animator; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        //transform.position += movement * Time.deltaTime * moveSpeed;

        horizontalMove = Input.GetAxisRaw("Horizontal") * moveSpeed; 

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
    }
}
