using UnityEngine;
using System.Collections;

public class UnityChanDemo1 : MonoBehaviour {

    private Animator animator;
    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    
    
    void Update () {
        if (Input.GetKey(KeyCode.W)) {
            
            transform.position += transform.forward * 0.01f;
        }

        if (Input.GetKeyDown(KeyCode.D)) {
            transform.Rotate(0, 10, 0);
        }
        

        if (Input.GetKeyDown(KeyCode.A)) {
            transform.Rotate(0, -10, 0);
        }


        if (Input.GetKey(KeyCode.W)||Input.GetKey(KeyCode.D)||Input.GetKey(KeyCode.A)) {
        animator.SetBool("is_running", true);
        } else {
            animator.SetBool("is_running", false);
        }
    }


    
}