using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
        // public Transform player;
        // public float moveSpeed = 2f;
        private Rigidbody2D rb;
        public int health = 50; 
        
        public bool isAttacking = false;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
        Debug.Log(gameObject.transform.position);

    }

    // Update is called once per frame
    void Update()
    {
    //     if(player == null) return;
    //     Vector2 playerPosition = player.position;
    //     Vector2 direction = ((Vector2)player.position - rb.position).normalized;
    //     Vector2 newPos = rb.position + direction * moveSpeed * Time.fixedDeltaTime;
    //     if(direction.x > 0.2){
    //         currentAnimation = Characters.ChangeAnimation(currentAnimation, "walk_right", animator);
            
    //     }
    //     else if(direction.x < -0.2){
    //         currentAnimation = Characters.ChangeAnimation(currentAnimation, "walk_left ", animator);
    //     }
    //     else{
    //         if(direction.y > 0){
    //         currentAnimation = Characters.ChangeAnimation(currentAnimation, "walk_up", animator);

    //         }
    //         else{
    //         currentAnimation = Characters.ChangeAnimation(currentAnimation, "walk_down", animator);

    //         }
    //     }
    //     rb.MovePosition(newPos);
    //     Debug.Log("direction: " + direction);
    }
}
