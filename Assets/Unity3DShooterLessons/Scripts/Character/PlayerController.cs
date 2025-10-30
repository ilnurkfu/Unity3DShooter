using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent (typeof(PlayerData))]
[RequireComponent (typeof(PlayerInput))]
[RequireComponent (typeof(PlayerMovement))]
public class PlayerController : CharacterController
{
    [SerializeField] PlayerUI ui;

    [SerializeField] private PlayerInput playerInput;

    [SerializeField] private PlayerMovement playerMovement;

    [SerializeField] private CameraMovement cameraController;

    private void Awake()
    {
        characterData = GetComponent<PlayerData>();
        playerInput = GetComponent<PlayerInput>();
        playerMovement = GetComponent<PlayerMovement>();
    }

    private void Start()
    {
        characterData.Health = characterData.MaxHealth;
        ui.SetHealthInfo(characterData.Health, characterData.MaxHealth);
        UpdateConf();
    }
    
    private void Update()
    {
        playerInput.RefreshInput();

        playerMovement.Move(playerInput.MoveInput, playerInput.IsSprint);

        Vector2 mouseInput = playerInput.CameraInput;

        playerMovement.Rotate(mouseInput.x);

        if (cameraController != null)
        {
            cameraController.Rotate(mouseInput.y);
        }

        if(playerInput.IsJumpPress)
        {
            playerMovement.Jump();
        }    
    }

    public void UpdateConf()
    {
        playerMovement.MovementConf = CreateMovementConf();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out ITriggerObject newTriggerObject))
        {
            newTriggerObject.Trigger(this);
        }
    }

    public override void ApplyDamage(int damage)
    {
        base.ApplyDamage(damage);

        ui.SetHealthInfo(characterData.Health, characterData.MaxHealth);
    }

    public override void Healing(int additiveHealth)
    {
        base.Healing(additiveHealth);

        ui.SetHealthInfo(characterData.Health, characterData.MaxHealth);
    }
}