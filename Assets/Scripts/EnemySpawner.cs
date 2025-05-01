using UnityEngine;
public class EnemySpawner: MonoBehaviour{
    public GameObject enemyPrefab;
    public Vector3 position;
    public void spawnEnemy(){
        enemyPrefab.transform.Find("Commander-chan/UnitRoot/Root/BodySet/P_Body/ArmSet/ArmL/P_LArm/P_Weapon/L_Weapon").gameObject.tag = "Enemy Weapon";
        Debug.Log("Called spawnEnemy");
        Instantiate(enemyPrefab, position, Quaternion.identity);
    }

}