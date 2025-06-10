using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline.Actions;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public GameObject player { get; private set; }
    public Character character;

    private void Awake()
    {
        instance = this;
        character = GetComponent<Character>();
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
        Character Player = new Character();
        player = Player.gameObject;
    }
}
