using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml.Serialization;

public class CameraController : MonoBehaviour
{
    public float mouseMove = 4f;
    public GameObject player;
    private Vector3 offset;

    // Start is called before the first frame update
    private void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    private void Update()
    {
        if (PlayerPrefs.GetInt("isInverted") == 1)
        {
            if (Input.GetMouseButton(1))
            {
                offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * mouseMove, Vector3.up) *
                         Quaternion.AngleAxis(Input.GetAxis("Mouse Y") * mouseMove, Vector3.left) * offset;
                var position = player.transform.position;
                transform.position = position + offset;
                transform.LookAt(position);
            }
            else
            {
                transform.position = player.transform.position + offset;
            }
        }
        else
        {
            if (Input.GetMouseButton(1))
            {
                offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * mouseMove, Vector3.up) *
                         Quaternion.AngleAxis((Input.GetAxis("Mouse Y") * -1) * mouseMove, Vector3.left) * offset;
                var position = player.transform.position;
                transform.position = position + offset;
                transform.LookAt(position);
            }
            else
            {
                transform.position = player.transform.position + offset;
            }
        }
    }
}
