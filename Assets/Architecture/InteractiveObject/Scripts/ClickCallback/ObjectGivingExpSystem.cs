using UnityEngine;

public class ObjectGivingExpSystem : BaseInteractiveObject, Interact
{
    public float Additional;
    public void Interact(GameObject caller)
    {
        
        if (IsAbleToInteract())
            caller.GetComponent<ExperianceSystem>().AddExp(Additional);
    }
}
