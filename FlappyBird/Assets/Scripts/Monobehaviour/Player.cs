using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator animator;
    [SerializeField] private float jumpForce = 5;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    public void MoveUp()
    {
        rb.linearVelocity = new Vector2(0, jumpForce);
    }

    void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.gameObject.CompareTag("DeathZone"))
        {
            // Call GameManager's GameOver
            GameManager.instance.GameOver();
        }
        else if (collision.gameObject.CompareTag("ScoreZone"))
        {
            // Increment score when passing through score zone
            GameManager.instance.IncrementScore();
        }
    }    

    public void isPlayerGoingUp()
    {
        if (rb.linearVelocity.y > 0)
        {
            animator.SetBool("PlayerUp", true);
        }
        else
        {
            animator.SetBool("PlayerUp", false);
        }
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            MoveUp();
        }
        isPlayerGoingUp();
    }

}
