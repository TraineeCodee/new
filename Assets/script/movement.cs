using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 5f;
    public float jump = 6f;
    public Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.linearVelocity = new Vector2(speed, rb.linearVelocityY);
            animator.SetBool("run", true);
            animator.SetBool("idle", false);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.linearVelocity = new Vector2(-speed, rb.linearVelocityY);
            animator.SetBool("run", true);
            animator.SetBool("idle", false);
        }

        if(Input.GetKeyUp(KeyCode.LeftArrow ) ||Input.GetKeyUp(KeyCode.RightArrow))
        {
            rb.linearVelocity = new Vector2(0f, 0f);
            animator.SetBool("idle", true);
             animator.SetBool("run", false);
        }
        
         if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocityX, jump);
        }
        

    }
    
}
