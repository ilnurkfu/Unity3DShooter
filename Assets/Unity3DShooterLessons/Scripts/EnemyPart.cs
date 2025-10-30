using UnityEngine;

public class EnemyPart : MonoBehaviour
{
    [SerializeField] private BodyPart bodyPart;

    [SerializeField] private CharacterController characterController;
    public void TranslateDamage(int newDamage)
    {
        characterController.ApplyDamage((int)(newDamage * bodyPart.damageMultiplier));
    }
}

[System.Serializable]
public struct BodyPart
{
    public string partName;

    public float damageMultiplier;
}
