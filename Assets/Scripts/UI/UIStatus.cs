using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIStatus : MonoBehaviour
{
    [SerializeField] private Character character;
    [SerializeField] private TextMeshProUGUI atk;
    [SerializeField] private TextMeshProUGUI def;
    [SerializeField] private TextMeshProUGUI maxHp;
    [SerializeField] private TextMeshProUGUI critical;

    public Button backButton;

    // Start is called before the first frame update
    private void Awake()
    {
        character = GetComponent<Character>();
    }
    void Start()
    {
        //backButton.onClick.AddListener(UIManager.Instance.UIMainMenu.OpenMainMenu);
        SetStat(GameManager.instance.player);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetStat(Character character)
    {
        atk.text = character.Atk.ToString();
        def.text = character.Def.ToString();
        maxHp.text = character.MaxHp.ToString();
        critical.text = character.Critical.ToString();
    }
}
