using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    public static CharacterManager Instance;

    [SerializeField] private Character characterChosen;//serialized so you can see it
    public Character _characterChosen { get { return characterChosen; } }

    private void Awake()
    {
        Instance = this;
    }

    public void SelectCharacter(Character characterSelected)
    {
        characterChosen = characterSelected;
    }
}