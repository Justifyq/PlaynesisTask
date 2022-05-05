using UnityEngine;

[CreateAssetMenu (menuName ="Spawnpoints config")]
public class SpawnPointsData : ScriptableObject
{
    [SerializeField] private Vector3[] _spawnPoints;
    public Vector3[] SpawnPoints => this._spawnPoints;
}
