using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachPlayer : MonoBehaviour
{

    public GameObject nP;

    // Start is called before the first frame update
    void Start()
    {

        
        nP = GameObject.Find("Warrior_Sheet-Effect_0 (1)");



        for (var i = 0; i < 5; i++)
        {
            Instantiate(nP, new Vector3(i * 2.0f, 0, 0), Quaternion.identity);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
