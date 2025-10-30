using UnityEngine;

public abstract class CollisionObject : MonoBehaviour, ICollisionObject
{
    public abstract void Collision(PlayerController playerController);
}
