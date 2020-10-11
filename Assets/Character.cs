using UnityEngine;

[System.Serializable, CreateAssetMenu(fileName ="New Character", menuName = "Create Character")]
public class Character : ScriptableObject
{
    [SerializeField] private string characterName;
    public string _characterName { get { return characterName; } }
}