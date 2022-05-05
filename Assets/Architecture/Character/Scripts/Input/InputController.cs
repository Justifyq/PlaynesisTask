using UnityEngine;

public class InputController : MonoBehaviour
{
    private Character _character;

    private void Awake()
    {;
        _character = GetComponent<Character>();
    }
      
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            _character.Interact();
        }
        if (Input.GetMouseButtonUp(1))
        {
            _character.Move();
        }
    }
}
