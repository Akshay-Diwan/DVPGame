using UnityEngine;
using System.Collections;
public class PlayerController : MonoBehaviour
{
    Rigidbody2D body;
    public Vector2 movement;
    private string currentAnimation = "";
    float horizontal;
    float vertical;
    private string setIdle = "idle_up";
    public float runSpeed = 5.0f;
    private Animator animator;
    public int health = 100;
    public bool isAttacking = false;
    private Coroutine regehealth;
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
            movement = new Vector2(horizontal, 0);
        }
        else{
            movement =new Vector2(0, vertical);
        }
        if(gameObject.layer == 22){
            regehealth = StartCoroutine(RegenerateHealth());
        }

     
    }
    private void FixedUpdate()
    {
        body.linearVelocity = movement * runSpeed;
    }

   IEnumerator RegenerateHealth(){
        while(true){
            // Debug.Log("Before 2 sec");
            yield return new WaitForSeconds(2f);
                if(health < 100 && health > 0 && gameObject.layer == 22){
                    health = Mathf.Min(health + 10, 100);
                    Debug.Log("Healing: " + health);
            }
        }
     
    }

}
