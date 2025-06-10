using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private UIInventory uiInventory;
    public UIInventory UIInventory { get { return uiInventory; } }
    [SerializeField] private UIMainMenu uiMainMenu;
    public UIMainMenu UIMainMenu { get { return uiMainMenu; } }
    [SerializeField] private UIStatus uiStatus;
    public UIStatus UIStatus { get { return uiStatus; } }

    private static UIManager instance;
    public static UIManager Instance
    {
        get
        {
            if (instance == null) instance = new UIManager();
            return instance;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
