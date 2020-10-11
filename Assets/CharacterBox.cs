using UnityEngine;

public class CharacterBox : MonoBehaviour
{
    [SerializeField] private Character characterToSelect;

    public void OnCharacterButtonPress()
    {
        CharacterManager.Instance.SelectCharacter(characterToSelect);
    }
}