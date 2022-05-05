using UnityEngine;

public class ObjectIndicator : MonoBehaviour
{
    private void Awake()
    {
        GetComponentInParent<BaseInteractiveObject>().SetIndicator(this);
        Close();
    }
    private void Start()
    {

    }
    public void Show()
    {
        this.gameObject.SetActive(true);
    }

    public void Close()
    {
        this.gameObject.SetActive(false);
    }
}
