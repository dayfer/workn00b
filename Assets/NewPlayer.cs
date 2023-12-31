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

        animator.SetBool("isRunning", false);

        float fInputH = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(fInputH, 0f, 0f);
        if(fInputH != 0)
        {
            animator.SetBool("isRunning", true);
            transform.position += movement * Time.deltaTime * moveSpeed;
        }



        float fInputV = Input.GetAxis("Vertical");
        Vector3 movement2 = new Vector3(0f, fInputV, 0f);
        if (fInputV != 0)
        {
            animator.SetBool("isRunning", true);
            transform.position += movement2 * Time.deltaTime * moveSpeed;
        }

    }


}
