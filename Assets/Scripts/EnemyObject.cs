using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "enemyAttributes", menuName = "Enemy/New Enemy")]
public class EnemyObject : ScriptableObject
{
    public string name;
    public int health;
    public float valueMoneyEnemy;

    public RuntimeAnimatorController animController;
}
