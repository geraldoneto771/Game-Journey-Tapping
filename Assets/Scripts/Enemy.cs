using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public EnemyObject enemySettings;
    public JogadorObject jogadorSettings;
    
    public string name;
    public int health;
    public float valueMoneyEnemy = 0;
    
    private Animator anim;

    public void Start()
    {
        
        anim = GetComponent<Animator>();
        anim.runtimeAnimatorController = enemySettings.animController;
        name = enemySettings.name;
        health = enemySettings.health;
        valueMoneyEnemy = enemySettings.valueMoneyEnemy;

    }

    public void TapAction()
    {
        
        enemySettings.health -= jogadorSettings.tapValue;

        
        jogadorSettings.MyMoney += 0.10f;

        if (enemySettings.health <= 0)
        {
            jogadorSettings.MyMoney += enemySettings.valueMoneyEnemy;
            

        }

    }

}
