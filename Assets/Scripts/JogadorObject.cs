using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "JogadorAttributes", menuName = "Jogador/New Enemy")]
public class JogadorObject : ScriptableObject
{
    public string name;
    public float MyMoney;
    public int health;
    public float tapValue;
    public RuntimeAnimatorController animController;
}
