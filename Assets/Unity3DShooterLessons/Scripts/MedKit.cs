using UnityEngine;

public class MedKit : TriggerObject
{
    [SerializeField] private int additiveHeath;
    
    public override void Trigger(PlayerController playerController)
    {
        playerController.Healing(additiveHeath);    
        Destroy(gameObject);
    }
}
