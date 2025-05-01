using UnityEngine;

public class EnemyWeaponController: MonoBehaviour
{
    public int attack = 10;
    void Start(){
        Debug.Log(gameObject.transform.root.gameObject.name);
    }
    void OnTriggerEnter2D(Collider2D other){
        bool isAttacking = false;
        if(gameObject.tag == "Player Weapon"){
            isAttacking = gameObject.transform.root.gameObject.GetComponent<PlayerController>().isAttacking;
        }
        else{
            isAttacking = gameObject.transform.root.gameObject.GetComponent<EnemyController>().isAttacking;
            // Debug.Log("Enemy Weapon: " + isAttacking);

        }
        // Debug.Log(isAttacking);
        if((gameObject.tag == "Enemy Weapon" && other.gameObject.tag == "Player") || (gameObject.tag == "Player Weapon" && other.gameObject.tag == "Enemy"  ) && isAttacking){
            // Debug.Log(gameObject.tag + " Attacked");
            if(gameObject.tag == "Enemy Weapon") other.gameObject.GetComponent<PlayerController>().health -= attack;
            else other.gameObject.GetComponent<EnemyController>().health -= attack;
        }
        
    }
}