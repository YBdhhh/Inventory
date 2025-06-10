using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI characterID;
    [SerializeField] private TextMeshProUGUI description;
    [SerializeField] private TextMeshProUGUI gold;
    [SerializeField] private TextMeshProUGUI level;

    [SerializeField] private Image expBar;
    [SerializeField] private TextMeshProUGUI expText;

    public GameObject buttons;
    public Button statButton;
    public Button invenButton;

    public GameObject status;
    public GameObject inventory;
    

    // Start is called before the first frame update
    void Start()
    {
        statButton.onClick.AddListener(OpenStatus);
        invenButton.onClick.AddListener(OpenInventory);

    }

    // Update is called once per frame
    void Update()
    {
        SetCharacter(GameManager.instance.player);
    }

    public void OpenStatus()
    {
        buttons.SetActive(false);
        status.SetActive(true);
    }
    public void OpenInventory()
    {
        buttons.SetActive(false);
        inventory.SetActive(true);
    }
    public void OpenMainMenu()
    {
        buttons.SetActive(true);
        inventory.SetActive(false);
        status.SetActive(false);
    }


    public void SetCharacter(Character character)
    {
        characterID.text = character.CharacterID;
        description.text = character.Description;
        level.text = character.Level.ToString();
        gold.text = character.Gold.ToString();
        expBar.fillAmount = character.GetPercent();
        expText.text = ($"{character.CurrentExp} / {character.MaxExp}");
    }
}
