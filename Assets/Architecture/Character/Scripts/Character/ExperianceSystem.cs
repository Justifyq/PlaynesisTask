using UnityEngine;

public class ExperianceSystem : MonoBehaviour
{
    public float Exp;
    
    public void AddExp(float additional)
    {
        Exp += additional;
    }
    
    public float GetCurrentExp()
    {
        return Exp;
    }
}
