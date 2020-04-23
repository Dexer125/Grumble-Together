using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SimplePlatformController2 : MonoBehaviour
{

    [HideInInspector]
    public bool facingRight = true;
    [HideInInspector]
    public bool jump = false;
    public float moveForce = 365f;
    public float maxSpeed = 5f;
    public float jumpForce = 1000f;
    public Transform groundCheck;
    public string jumpButton = "Jump2";
    public string horizontalctrl = "Horizontal2";


    private bool grounded = false;
    private Animator anim;
    private Rigidbody2D rb2d;

    public GUIText countText2;
 
    public int count2;
   


    void Awake()
    {
        anim = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
        

    }


    void Start()
    {
        
        count2 = 0;
        SetCountText();

    }

    void Update()
    {
        grounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"));

        if (Input.GetButtonDown(jumpButton) && grounded)
        {
            jump = true;
        }


    }

    void FixedUpdate()
    {
        float h = Input.GetAxis(horizontalctrl);

        anim.SetFloat("Speed", Mathf.Abs(h));

        if (h * rb2d.velocity.x < maxSpeed)
            rb2d.AddForce(Vector2.right * h * moveForce);

        if (Mathf.Abs(rb2d.velocity.x) > maxSpeed)
            rb2d.velocity = new Vector2(Mathf.Sign(rb2d.velocity.x) * maxSpeed, rb2d.velocity.y);

        if (h > 0 && !facingRight)
            Flip();
        else if (h < 0 && facingRight)
            Flip();

        if (jump)
        {
            anim.SetTrigger(jumpButton);
            rb2d.AddForce(new Vector2(0f, jumpForce));
            jump = false;
        }
    }


    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }


    void SetCountText()
    {
       
        countText2.text = "Score: " + count2.ToString();


    }



    public void OnTriggerEnter2D(Collider2D other)

    {

        

        if (other.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count2 = count2 + 1;
            SetCountText();
        }

       

    }

    


}



