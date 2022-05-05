using UnityEngine;
using UnityEngine.UI;

public class DescriptionSystem : BaseInteractiveObject, Interact
{
    [SerializeField]
    private string _description;
    private Text _descriptionText;
    public void SetDescriptionUI(Text descriptionUI) => _descriptionText = descriptionUI; 
    public void Interact(GameObject caller)
    {
        if (IsAbleToInteract())
            ShowDescription();
    }

    private void ShowDescription()
    {
        bool isActive = _descriptionText.transform.gameObject.activeInHierarchy;
        _descriptionText.text = _description;
        if (!isActive)
            _descriptionText.transform.parent.gameObject.SetActive(true);
    }
    
    private void CloseDescription()
    {
        bool isActive = _descriptionText.gameObject.activeInHierarchy;
        if (isActive)
            _descriptionText.transform.parent.gameObject.SetActive(false);
    }

    private void OnDestroy()
    {
        CloseDescription();
    }
}
