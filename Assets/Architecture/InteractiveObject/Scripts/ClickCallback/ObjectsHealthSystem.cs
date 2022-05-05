using UnityEngine;

public class ObjectsHealthSystem : BaseInteractiveObject, Interact
{
    [SerializeField]
    private int health = 5;
    public void Interact(GameObject caller)
    {
        if (IsAbleToInteract())
            GetDamage();
    }

    private void GetDamage()
    {
        health--;
        if (health == 0)
        {
            Destroy(gameObject);
        }
    }

    private void Destroy()
    {
        Destroy(this.gameObject);
    }
}
