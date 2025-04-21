using UnityEngine;

public class Characters : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
        public static string ChangeAnimation(string currentAnimation, string animation, Animator animator){
        if(animation == currentAnimation){
            return currentAnimation;
        }
        animator.CrossFade(animation, 0.2f);
        return animation;
    }
}
