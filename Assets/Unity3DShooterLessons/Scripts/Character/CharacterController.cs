using System.Collections;
using UnityEngine;

public abstract class CharacterController : MonoBehaviour
{
    [SerializeField] protected CharacterData characterData;
    public virtual void ApplyDamage(int damage)
    {
        int newHealth = characterData.Health - damage;

        characterData.Health = Mathf.Clamp(newHealth, 0, characterData.MaxHealth);

        if (characterData.Health == 0)
        {
            Died();
        }
    }

    public virtual void Healing(int additiveHealth)
    {
        int newHealth = characterData.Health + additiveHealth;

        characterData.Health = Mathf.Clamp(newHealth, 0, characterData.MaxHealth);
    }

    protected void Died()
    {
        StartCoroutine(DiedCoroutine());
    }

    private IEnumerator DiedCoroutine()
    {
        float timerCurrentValue = characterData.DeathTimer;
        while (timerCurrentValue > 0)
        {
            timerCurrentValue -= Time.deltaTime;

            transform.localScale = Vector3.one * (timerCurrentValue / characterData.DeathTimer);

            yield return null;
        }

        Destroy(gameObject);
    }

    public MovementConf CreateMovementConf()
    {
        return new MovementConf(characterData.SprintMultiplier, characterData.Speed, characterData.JumpHeight);
    }
}
