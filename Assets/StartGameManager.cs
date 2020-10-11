using UnityEngine;
using TMPro;

public class StartGameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI characterNameText;

    [SerializeField] private GameObject characterSelectionPanel;

    public void StartGame()
    {
        if (CharacterManager.Instance._characterChosen != null)
        {
            characterSelectionPanel.SetActive(false);
            characterNameText.gameObject.SetActive(true);
            characterNameText.text = "You chose: " + CharacterManager.Instance._characterChosen.name;
        }
    }
}