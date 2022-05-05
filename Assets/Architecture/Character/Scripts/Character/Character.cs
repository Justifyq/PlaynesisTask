using UnityEngine;
using UnityEngine.AI;

public class Character : MonoBehaviour
{
    private NavMeshAgent _agent;
    private bool _canMove, _canInteract;

    private void Awake()
    {
        _canInteract = true;
        _canMove = true;
        _agent = GetComponent<NavMeshAgent>();     
    }

    public void Move()
    {
        if (_canMove)
        {
            _agent.ResetPath();
            _agent.SetDestination(CalculateMovePostion());
        }
                   
    }

    public void Interact()
    {
        Vector3 mousePosition = Input.mousePosition;
        Ray ray = Camera.main.ScreenPointToRay(mousePosition);
        RaycastHit hit;
        Debug.DrawRay(ray.origin, ray.direction * 5000, Color.red, 1000000f);
        if (Physics.Raycast(ray, out hit, Mathf.Infinity) & _canInteract)
        {
            if (hit.transform.GetComponent<BaseInteractiveObject>())
            {
                foreach (var interativeComponent in hit.transform.GetComponents<Interact>())
                {
                    interativeComponent.Interact(this.gameObject);
                }
            }
        }
    }

    private Vector3 CalculateMovePostion()
    {
        Vector3 mousePosition = Input.mousePosition;
        Vector3 movePostion = Camera.main.ScreenToWorldPoint(mousePosition) - Camera.main.transform.position;
        return movePostion;
    }

    public void StopMovementAndInteraction()
    {
        _agent.isStopped = true;
        _canMove = false;
        _canInteract = false;
    }
}
