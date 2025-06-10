using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour
{
    [SerializeField] private string characterID;
    public string CharaterID {  get; private set; }
    [SerializeField] private string description;
    public string Description { get; private set; }
    [SerializeField] private int gold = 2000;
    public int Gold { get; private set; }
    [SerializeField] private int currentExp = 0;
    public int CurrentExp { get; private set; }
    [SerializeField] private int maxExp = 10;
    public int MaxExp { get; private set; }

    [SerializeField] private GameObject exp;

    [SerializeField] private int level = 1;
    public int Level { get; private set; }
    
    [SerializeField] public int atk = 35;
    public int Atk {  get; set; }
    [SerializeField] private int def = 40;
    public int Def { get; private set; }
    [SerializeField] private int maxHp = 100;
    public int MaxHp { get; private set; }
    [SerializeField] private int critical = 25;
    public int Critical { get; private set; }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public float GetPercent()
    {
        return (float)currentExp / maxExp;
    }
}
