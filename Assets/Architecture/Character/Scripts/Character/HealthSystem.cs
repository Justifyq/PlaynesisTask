using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    private int Health;
    public int MaxHealth;

    private DeathUI _deathUI;

    private void Awake()
    {
        Health = MaxHealth;     
    }

    public void AddHealth(int additional)
    {
        if (Health + additional > MaxHealth)
        {
            Health = MaxHealth;
        }
        else
        {
            Health += additional;
        }
    }

    public void GetDamage(int damage)
    {
        if (Health - damage <= 0)
        {
            Health = 0;
            Death();
        }
        else
        {
            Health -= damage;
        }
    }
    public void Death()
    {
       Character character = GetComponent<Character>();
        character.StopMovementAndInteraction();
        if (_deathUI != null)
        {
            _deathUI.ShowDeathUI();
        }
    }

    public void SetDeathUI(DeathUI deathUI) => _deathUI = deathUI;
  
}
