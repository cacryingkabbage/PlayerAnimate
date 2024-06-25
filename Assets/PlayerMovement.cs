using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Animator playerAnim;
    void Start()
    {
        playerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            playerAnim.SetBool("Walk",true);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            playerAnim.SetBool("Walk", false);
        }
    }
}
