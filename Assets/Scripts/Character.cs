using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour
{
    [Header("Main")]
    [SerializeField] private string characterID;
    public string CharacterID {  get; private set; }
    [SerializeField] private string description;
    public string Description { get; private set; }
    [SerializeField] private int gold;
    public int Gold { get; private set; }
    [SerializeField] private int currentExp;
    public int CurrentExp { get; private set; }
    [SerializeField] private int maxExp;
    public int MaxExp { get; private set; }

    [SerializeField] private int level;
    public int Level { get; private set; }

    [Header("status")]
    [SerializeField] public int atk;
    public int Atk {  get; set; }
    [SerializeField] private int def;
    public int Def { get; private set; }
    [SerializeField] private int maxHp;
    public int MaxHp { get; private set; }
    [SerializeField] private int critical;
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

    public Character(string characterID,  string description, int gold,int currentExp, int maxExp, int level,  int atk, int def,int maxHp, int critical)
    {
        this.CharacterID = characterID;
        this.Description = description;
        this.Gold = gold;
        this.CurrentExp = currentExp;
        this.MaxExp = maxExp;
        this.Level = level;
        this.Atk = atk;
        this.Def = def;
        this.MaxHp = maxHp;
        this.Critical = critical;
    }
}
