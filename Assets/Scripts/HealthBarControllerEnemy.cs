using UnityEngine;
using UnityEngine.UI;

public class HealthBarFollowEnemy : MonoBehaviour
{
    public Image fillImage;
    public EnemyController enemy; // Link to your existing script

    void Update()
    {
        float fillAmount = Mathf.Clamp01(enemy.health / 50f);
        fillImage.fillAmount = fillAmount;
    }
}

