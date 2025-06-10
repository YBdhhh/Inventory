using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    public Button backButton;

    // Start is called before the first frame update
    void Start()
    {
        backButton.onClick.AddListener(UIManager.Instance.UIMainMenu.OpenMainMenu);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
