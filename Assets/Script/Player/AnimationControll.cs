using Unity.VisualScripting;
using UnityEngine;

public class AnimationControll : MonoBehaviour
{
    public Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            animator.SetFloat("Speed", 1);
        }
        if (Input.GetKey(KeyCode.A))
        {
            animator.SetFloat("Speed", -1);
        }
        else if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.A))
        {
            animator.SetFloat("Speed", 0);
        }
    }
}
