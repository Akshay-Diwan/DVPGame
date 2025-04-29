using UnityEngine;
using Pathfinding;
using System.Threading.Tasks;
public class NoSpriteRotation : MonoBehaviour
{
    private Animator animator;
    private string currentAnimation = "";
    public Transform target;
    private AIPath aipath;
    private Vector3 scale;
    private Vector3 dir;
    private int health = 50;
    void Start()
    {
        aipath = gameObject.transform.root.gameObject.GetComponent<AIPath>();
        animator = GetComponent<Animator>();
        scale = gameObject.transform.localScale;
       
    }

    async Task Update()
    {
        int ogHealth = health + 1 - 1;
        health = gameObject.transform.root.gameObject.GetComponent<EnemyController>().health;
        
        float distance = (target.position - gameObject.transform.position).magnitude;
        if(health == 0){
            // Debug.Log("Game Over");
            animator.SetTrigger("4_Death");
            animator.SetBool("isDeath", true);
            animator.SetBool("1_Move", false);
            aipath.enabled = false;
        }
        else if(health > 0){
        
            if(health < ogHealth){
                Debug.Log("Ye chal raha hai");
                animator.SetTrigger("3_Damaged");
            }
            // Debug.Log(distance);
            if(distance < 1.5f){
                    // animator.speed = 0.5f;
                    animator.SetTrigger("2_Attack");

                    gameObject.transform.root.gameObject.GetComponent<EnemyController>().isAttacking = true;
                    Task.Delay(250);
                    gameObject.transform.root.gameObject.GetComponent<EnemyController>().isAttacking = false;
                    
                    // animator.speed = 1f;
                    
                    
            }
            dir = target.position - gameObject.transform.position;
            if(dir.x < 0){
            gameObject.transform.localScale = new Vector3(-1, 1, 1);
              
            }
            else if(dir.x > 0){
                gameObject.transform.localScale = new Vector3(1, 1, 1);

            }
        }
    
        
    }
}