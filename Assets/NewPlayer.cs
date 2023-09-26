using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPlayer : MonoBehaviour
{
    private float moveSpeed = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Jump();
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * moveSpeed;

        Vector3 movement2 = new Vector3(0f, Input.GetAxis("Vertical"), 0f);
        transform.position += movement2 * Time.deltaTime * moveSpeed;
    }
}
