using UnityEngine;

public class BaseInteractiveObject : MonoBehaviour
{
    private bool _isActive = false;
    private ObjectIndicator _indicator;

    public void SetIndicator(ObjectIndicator indicator) => _indicator = indicator;

    public void Activate()
    {
        _isActive = true;
        if (_indicator != null)
            _indicator.GetComponent<ObjectIndicator>().Show();
    }

    public void Deactivate()
    {
        _isActive = false;
        if (_indicator != null)
            _indicator.GetComponent<ObjectIndicator>().Close();
    }

    public bool IsAbleToInteract()
    {
        return _isActive;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Character>())
            Activate();

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<Character>())
            Deactivate();
    }
}
