using UnityEngine;
public class JumpScript : MonoBehaviour {
    void Update () {
        Animator anim = GetComponent<Animator>();   // ...(1)
 
        if(Input.GetKeyDown(KeyCode.Space))   // ...(2)
        {
            anim.SetTrigger("is_jumping");
        }
        
        /*
        AnimatorStateInfo state = anim.GetCurrentAnimatorStateInfo(0);   // ...(3)
        if(state.IsName("Locomotion.Jump"))   // ...(4)
        {
            anim.SetTrigger("is_jumping");
        }*/
    }
}