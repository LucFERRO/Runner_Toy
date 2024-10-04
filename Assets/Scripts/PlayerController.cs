using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRigid;
    private CharacterController characterController;
    public float speed;
    public float jumpSpeed;
    private float ySpeed;

    void Start()
    {
        playerRigid = GetComponent<Rigidbody>();
        characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), ySpeed, Input.GetAxis("Vertical"));
        characterController.Move(move * speed * Time.deltaTime);

        ySpeed += Physics.gravity.y * Time.deltaTime;

        if (characterController.isGrounded)
        {
            ySpeed = -0.5f;

            if (Input.GetKeyDown(KeyCode.Space))
            {
                ySpeed = jumpSpeed;
            }
        }
    }

    void FixedUpdate()
    {
        playerRigid.AddForce(playerRigid.mass * playerRigid.velocity, ForceMode.Force);
        Debug.Log(characterController.velocity);
    }
}
