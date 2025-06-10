using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline.Actions;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public GameObject Player { get; private set; }
    public Character player;

    private void Awake()
    {
        instance = this;
        SetData();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void SetData()
    {
         player = new Character("SYB", "일어나 핫산 코딩해야지.. 일어나 핫산 코딩해야지.. 일어나 핫산 코딩해야지..", 2000, 0, 10, 1, 35, 40, 100, 25);
    }
}
