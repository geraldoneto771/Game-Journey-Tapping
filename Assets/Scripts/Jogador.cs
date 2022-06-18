using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    public JogadorObject jogadorSettings;
    Game game;
    public string name;
    public float myMoney = 0.0f;
    public int health;
    private Animator anim;
    public float tapValue;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.runtimeAnimatorController = jogadorSettings.animController;
        name = jogadorSettings.name;
        health = jogadorSettings.health;
        myMoney = jogadorSettings.MyMoney;
        tapValue = jogadorSettings.tapValue;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
