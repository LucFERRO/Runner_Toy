using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;

    void Start()
    {
        Vector3 cameraPos = new Vector3(player.position.x, player.position.y + 3.5f, player.position.z - 5);
        Quaternion cameraRot = Quaternion.Euler(20, 0, 0);
        transform.position = cameraPos;
        transform.rotation = cameraRot;
    }

    void Update()
    {
        Vector3 cameraPos = new Vector3(player.position.x, player.position.y + 3.5f, player.position.z - 5);
        transform.position = cameraPos;
    }
}
