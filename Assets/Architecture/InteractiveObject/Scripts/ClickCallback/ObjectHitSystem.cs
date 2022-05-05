using UnityEngine;

public class ObjectHitSystem : BaseInteractiveObject, Interact
{
    [SerializeField]
    private int _damage = 1;
    public void Interact(GameObject caller)
    {
        if (IsAbleToInteract())
            caller.GetComponent<HealthSystem>().GetDamage(_damage);
    }
}
