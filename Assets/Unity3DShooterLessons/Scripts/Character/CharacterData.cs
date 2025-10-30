using System.Collections;
using UnityEngine;

public abstract class CharacterData : MonoBehaviour
{
    [SerializeField] protected int health;
    [SerializeField] protected int maxHealth;

    [SerializeField] protected float speed;
    [SerializeField] protected float sprintMultiplier;
    [SerializeField] protected float deathTimer;
    [SerializeField] protected float jumpHeight;

    public int Health
    {
        get
        {
            return health;
        }
        set
        {
            health = value;
        }
    }

    public int MaxHealth
    {
        get
        {
            return maxHealth;
        }
    }

    public float Speed
    {
        get
        {
            return speed;
        }
    }

    public float SprintMultiplier
    {
        get
        {
            return sprintMultiplier;
        }
    }

    public float DeathTimer
    {
        get
        {
            return deathTimer;
        }
    }

    public float JumpHeight
    {
        get
        {
            return jumpHeight;
        }
    }

    //public virtual void Healing(int additiveHealth)
    //{
    //    int newHealth = health + additiveHealth;

    //    health = Mathf.Min(newHealth, maxHealth);

    //    //ui.SetHealthInfo(health, maxHealth);
    //}

    //public virtual void ApplyDamage(int damage)
    //{
    //    int newHealth = health - damage;

    //    health = Mathf.Max(newHealth, 0);

    //    if (health == 0)
    //    {
    //        Died();
    //    }

    //    //ui.SetHealthInfo(health, maxHealth);
    //}

    //public MovementConf CreateMovementConf()
    //{
    //    return new MovementConf(SprintMultiplier, speed, jumpHeight);
    //}

    //private void Died()
    //{
    //    StartCoroutine(DiedCoroutine());
    //}

    //protected virtual IEnumerator DiedCoroutine()
    //{
    //    float timerCurrentValue = deathTimer;
    //    while (timerCurrentValue > 0)
    //    {
    //        timerCurrentValue -= Time.deltaTime;

    //        transform.localScale = Vector3.one * (timerCurrentValue / deathTimer);

    //        yield return null;
    //    }

    //    Destroy(gameObject);
    //}
}
