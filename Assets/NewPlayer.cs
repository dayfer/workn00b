using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPlayer : MonoBehaviour
{
    private float moveSpeed = 2;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Jump();

        animator.SetBool("isRunning", false);
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * moveSpeed;

        Vector3 movement2 = new Vector3(0f, Input.GetAxis("Vertical"), 0f);
        transform.position += movement2 * Time.deltaTime * moveSpeed;
    }
}
