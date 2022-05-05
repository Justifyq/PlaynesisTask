using UnityEngine;

[CreateAssetMenu(menuName = "All Objects Data")]
public class AllObjectsData : ScriptableObject
{
    [SerializeField] private GameObject[] _item;
    public GameObject[] Item => this._item;
}
