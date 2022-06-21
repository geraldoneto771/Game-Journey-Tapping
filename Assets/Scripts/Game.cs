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
    public GameObject textAmountEnemy;
    public GameObject textNivel;
    public int amountEnemy = 1;
    public int maxAmountEnemey = 8;
    public int nivel;
    
   // public CanvasGroup canvasButtonBuy;
    
    // Start is called before the first frame update
    void Start()
    {
        //canvasButtonBuy.blocksRaycasts = false;
        amountEnemy = 1;
        maxAmountEnemey = 8;
}

    // Update is called once per frame
    void Update()
    {
        texNameEnemy.GetComponent<TMPro.TextMeshProUGUI>().text = enemySettings.name + " - " + amountEnemy+  "     " + enemySettings.health + "HP";
        texMyMoney.GetComponent<TMPro.TextMeshProUGUI>().text = "$" + jogadorSettings.MyMoney.ToString("f2");
        textAmountEnemy.GetComponent<TMPro.TextMeshProUGUI>().text = amountEnemy.ToString() + "/" + maxAmountEnemey.ToString();
        textNivel.GetComponent<TMPro.TextMeshProUGUI>().text = "Nivel " + nivel.ToString();
        
        /* if (enemySettings.health <= 0)
         {
             //canvasButtonBuy.blocksRaycasts = true;
             enemySettings.health = 20;
             amountEnemy += 1;

             texNameEnemy.GetComponent<TMPro.TextMeshProUGUI>().text = enemySettings.name + " " + amountEnemy + "     " + enemySettings.health + "HP";
         }*/
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

    public void TapGames()
    {
        enemySettings.health -= jogadorSettings.tapValue;


        jogadorSettings.MyMoney += 0.10f;
        if (enemySettings.health <= 0)
        {
            jogadorSettings.MyMoney += enemySettings.valueMoneyEnemy;
            //canvasButtonBuy.blocksRaycasts = true;
            enemySettings.health = 20;
            amountEnemy++;

            texNameEnemy.GetComponent<TMPro.TextMeshProUGUI>().text = name + " " + amountEnemy.ToString() + "     " + enemySettings.health + "HP";

            //Alterar cor do quadrado

            if (amountEnemy >= 8)
            {
                amountEnemy = 1;
                nivel++;
                textNivel.GetComponent<TMPro.TextMeshProUGUI>().text = nivel.ToString();

            }
        }
    }
   
}
