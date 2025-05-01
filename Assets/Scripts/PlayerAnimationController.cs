using UnityEngine;
using System.Threading.Tasks;
public class PlayerAnimationController: MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector3 scale;
    private Animator animator;
    private int health = 100;
 
    void Start(){
         rb = gameObject.transform.root.gameObject.GetComponent<Rigidbody2D>();
         animator = gameObject.GetComponent<Animator>();
        scale = gameObject.transform.localScale;
        Debug.Log("Name is : " + gameObject.transform.root.gameObject.name);
        Debug.Log("scale is : " + scale);
        

    }
    async void Update(){
        PlayerController rootController = gameObject.transform.root.gameObject.GetComponent<PlayerController>();
        int ogHealth = health;
        health = rootController.health;
        if(health == 0){
            Debug.Log("Game Over");
            animator.SetTrigger("4_Death");
            animator.SetBool("isDeath", true);
            animator.SetBool("1_Move", false);
            gameObject.transform.root.gameObject.GetComponent<PlayerController>().health = -1;
        }
        else if(health > 0){
            // check if damaged
            if(health < ogHealth){
                Debug.Log(health);
                animator.SetTrigger("3_Damaged");
            }
        // attack animation
          if(Input.GetMouseButtonDown(0)){

            animator.SetTrigger("2_Attack");
            gameObject.transform.root.gameObject.GetComponent<PlayerController>().isAttacking = true;
            Debug.Log("animation controller" + gameObject.transform.root.gameObject.GetComponent<PlayerController>().isAttacking);

            await Task.Delay(500);
            gameObject.transform.root.gameObject.GetComponent<PlayerController>().isAttacking = false;

        }
        // check if moving
        if(rb.linearVelocity.x < -0.1 || rb.linearVelocity.x > 0.1){
            animator.SetBool("1_Move", true);
        }
        else{
            animator.SetBool("1_Move", false);
        }
        // check for button clicks
        if(rootController.movement.x > 0){
            gameObject.transform.localScale = new Vector3(-1, 1, 1); 

        }
        else if(rootController.movement.x < 0){
            gameObject.transform.localScale = new Vector3(1, 1, 1); 

        }  
        }
    }
}