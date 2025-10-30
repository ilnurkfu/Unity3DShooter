using UnityEngine;
using UnityEngine.InputSystem;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Transform cameraTransform;

    private void Awake()
    {
        cameraTransform = transform;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void Rotate(float mouseY)
    {
        cameraTransform.Rotate(new Vector3(-mouseY, 0));
    }
}
