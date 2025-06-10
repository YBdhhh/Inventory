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
        characterID.text = GameManager.instance.character.CharaterID;
        description.text = GameManager.instance.character.Description;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateUI();
        
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

    public void UpdateUI()
    {
        expBar.fillAmount = GameManager.instance.character.GetPercent();
        expText.text = ($"{GameManager.instance.character.CurrentExp} / {GameManager.instance.character.MaxExp}");
    }
}
