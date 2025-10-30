using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private bool isSprint;
    [SerializeField] private bool isJumpPress;

    [SerializeField] private Vector2 moveInput;
    [SerializeField] private Vector2 cameraInput;

    public bool IsSprint
    {
        get
        {
            return isSprint;
        }
    }

    public bool IsJumpPress
    {
        get
        {
            return isJumpPress;
        }
    }

    public Vector2 MoveInput
    {
        get
        {
            return moveInput;
        }
    }

    public Vector2 CameraInput
    {
        get
        {
            return cameraInput;
        }
    }

    public void RefreshInput()
    {
        isSprint = Input.GetKey(KeyCode.LeftShift);
        isJumpPress = Input.GetKeyDown(KeyCode.Space);

        moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        cameraInput = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
    }
}
