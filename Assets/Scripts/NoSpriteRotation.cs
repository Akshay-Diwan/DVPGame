using UnityEngine;

public class NoSpriteRotation : MonoBehaviour
{
    private Quaternion originalRotation;
    private float zRotation;
    private Animator animator;
    private string currentAnimation = "";
    void Start()
    {
        originalRotation = transform.localRotation;
        animator = GetComponent<Animator>();

    }

    void LateUpdate()
    {

        zRotation = transform.parent.localRotation.eulerAngles.z;
        // Debug.Log("Z- Rotation is : " + zRotation);
        if(zRotation > 255 && zRotation < 285){
            // Debug.Log("IN WALK DOWN");
            currentAnimation = Characters.ChangeAnimation(currentAnimation, "walk_down", animator);
        }
        else if(zRotation > 75 && zRotation < 105){
            // Debug.Log("IN WALK UP");

            currentAnimation = Characters.ChangeAnimation(currentAnimation, "walk_up", animator);
        }
        else if(zRotation > 270){
            // Debug.Log("IN WALK RIGHT");

            currentAnimation = Characters.ChangeAnimation(currentAnimation, "walk_right", animator);
        }
        else{
            // Debug.Log("IN WALK LEFT");
            currentAnimation = Characters.ChangeAnimation(currentAnimation, "walk_left", animator);

        }
        transform.eulerAngles = new Vector3(0f, 0f, 0f);
    }
}