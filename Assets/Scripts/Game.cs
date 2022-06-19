using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public EnemyObject enemySettings;
    public JogadorObject jogadorSettings;
    int vidaEnemy;
    public float MyMoney = 0.00f;
    
    public GameObject texNameEnemy;
    public GameObject texMyMoney;
   // public CanvasGroup canvasButtonBuy;
    
    // Start is called before the first frame update
    void Start()
    {
        //canvasButtonBuy.blocksRaycasts = false;
    }

    // Update is called once per frame
    void Update()
    {
        texNameEnemy.GetComponent<TMPro.TextMeshProUGUI>().text = enemySettings.name + "     " + enemySettings.health + "HP";
        texMyMoney.GetComponent<TMPro.TextMeshProUGUI>().text = "$" + jogadorSettings.MyMoney.ToString("f2");
        if(enemySettings.health <= 0)
        {
            //canvasButtonBuy.blocksRaycasts = true;
            enemySettings.health = 20;
        }
    }
    
    public void BuyTapEvolutionBasic()
    {
        if(jogadorSettings.MyMoney >= 2)
        {
            //jogadorSettings.tapValue += 0.10f;
           // canvasButtonBuy.blocksRaycasts = false;
            //jogadorSettings.MyMoney -= 2;
        }
        
    }

   
}
