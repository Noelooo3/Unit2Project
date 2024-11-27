using UnityEngine;

public abstract class InteractableObject : MonoBehaviour
{
    public abstract float MovementSpeed { get; set; }
    protected Health _health;

    public abstract void Attack();
    public abstract void Move(Vector2 direction, Vector2 lookDirection);
}
