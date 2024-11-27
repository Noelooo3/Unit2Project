using UnityEngine;

public class Health
{
    public int CurrentHealth { get; private set; }
    public int MaxHealth { get; private set; }

    public Health(int maxHealth, int currentHealth)
    {
        MaxHealth = maxHealth;
        CurrentHealth = currentHealth;
    }
}
