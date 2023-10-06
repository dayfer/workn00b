using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarriorPlayer : MonoBehaviour
{
    private float moveSpeed = 2;
    Animator animator;
    bool noseToTheEast = true; //drawn that way



    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        animator.SetBool("isRunning", false);
        animator.SetBool("isJumping", false);

        float fInputH = Input.GetAxis("Horizontal");

        if ((fInputH < 0.0 && noseToTheEast) || (fInputH > 0.0 && !noseToTheEast))
        {
            //flip it
            noseToTheEast = fInputH > 0.0;
            Vector3 currentScale = transform.localScale;
            currentScale.x = -currentScale.x;
            transform.localScale = currentScale;

        }

        if (fInputH != 0.0)
        {

            Vector3 movement = new Vector3(fInputH, 0f, 0f);
            animator.SetBool("isRunning", true);
            transform.position += movement * Time.deltaTime * moveSpeed;
        }



        float fInputV = Input.GetAxis("Vertical");
        Vector3 movement2 = new Vector3(0f, fInputV, 0f);
        if (fInputV != 0.0)
        {
            animator.SetBool("isRunning", true);
            transform.position += movement2 * Time.deltaTime * moveSpeed;
        }

        if(Input.GetKey(KeyCode.Space))
        {
            animator.SetBool("isJumping", true);
        }


    }
}
