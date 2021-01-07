using System.Runtime;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public Transform player;
	public Vector3 cameraOffset;
    public float speed = 0.5f;

    void Start ()
    {
        cameraOffset = transform.position - player.position;
    }

    void LateUpdate()
    {
        Vector3 newPosition = player.position + cameraOffset;
        transform.position = Vector3.Slerp(transform.position, newPosition, speed);
    }
}
