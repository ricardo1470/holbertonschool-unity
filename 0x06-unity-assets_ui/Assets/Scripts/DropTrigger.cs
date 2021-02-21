using UnityEngine;

public class DropTrigger : MonoBehaviour
{
    // player object assignment
    public CharacterController player;
    
    //direction the player is moving
    public Vector3 movePlayer;
    
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Drop"))
        {
            //gravity = 9.8f;
                transform.position = new Vector3(0, 10, 0);
        }
    }
}
