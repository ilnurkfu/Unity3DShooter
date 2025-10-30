using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private int groundCount;

    private Transform objectTransform;

    private Rigidbody body;

    [SerializeField] private MovementConf movementConf;

    public MovementConf MovementConf
    {
        set
        {
            movementConf = value;
        }
    }

    private void Awake()
    {
        objectTransform = transform;
        body = GetComponent<Rigidbody>();
    }

    public void Move(Vector2 moveDirection, bool isSprint)
    {
        var verticalInput = moveDirection.y;
        var horizontalInput = moveDirection.x;
        var verticalMovement = objectTransform.forward * verticalInput;
        var horizontalMovement = objectTransform.right * horizontalInput;
        var movement = (verticalMovement + horizontalMovement).normalized;

        if (isSprint)
        {
            movement *= movementConf.sprintMultiplier;
        }

        var linearVelocityY = body.linearVelocity.y;
        //objectTransform.position += new Vector3(horizontalMovement, 0,vertivalMovement).normalized * movementSpeed * Time.deltaTime;
        //body.AddForce(new Vector3(horizontalMovement, 0, vertivalMovement).normalized * movementSpeed * Time.deltaTime, ForceMode.Impulse);
        body.linearVelocity = (movement * movementConf.speed + Vector3.up * linearVelocityY);
    }

    public void Jump()
    {
        if (groundCount > 0)
        {
            body.AddForce(Vector3.up * movementConf.jumpHeight);
        }
    }

    public void Rotate(float mouseX)
    {
        transform.Rotate(new Vector3(0, mouseX));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Ground>())
        {
            groundCount++;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<Ground>())
        {
            groundCount--;
        }
    }
}
