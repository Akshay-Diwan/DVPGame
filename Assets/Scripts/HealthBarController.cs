using UnityEngine;
using UnityEngine.UI;

public class HealthBarFollow : MonoBehaviour
{
    public Image fillImage;
    public PlayerController player; // Link to your existing script

    void Update()
    {
        float fillAmount = Mathf.Clamp01(player.health / 100f);
        fillImage.fillAmount = fillAmount;
    }
}

