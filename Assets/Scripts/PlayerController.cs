using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D body;
    private Vector2 movement;
    private string currentAnimation = "";
    float horizontal;
    float vertical;
    private string setIdle = "idle_up";
    public float runSpeed = 5.0f;
    private Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        body.constraints = RigidbodyConstraints2D.FreezeRotation;
        // ChangeAnimation("walk_down");
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        if(horizontal != 0){
            movement =new Vector2(horizontal, 0);
            if(horizontal == -1) {
                
                currentAnimation = Characters.ChangeAnimation(currentAnimation,"walk_left", animator);
                setIdle = "idle_left";
            }
            else{
                currentAnimation = Characters.ChangeAnimation(currentAnimation,"walk_right", animator);
                setIdle = "idle_right";
            }
        }
        else{
            movement =new Vector2(0, vertical);
            if(vertical == -1){ 
                currentAnimation = Characters.ChangeAnimation(currentAnimation,"walk_down", animator);
                setIdle = "idle_down";
            }
            else if(vertical == 1){
                currentAnimation = Characters.ChangeAnimation(currentAnimation,"walk_up", animator);
                setIdle = "idle_up";
            }
            else{
                currentAnimation = Characters.ChangeAnimation(currentAnimation, setIdle, animator);
            }
        }

    }
    private void FixedUpdate()
    {
        body.linearVelocity = movement * runSpeed;
    }

}
