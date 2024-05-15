using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //変数moneyを50で初期化
        int money = 100;
        //moneyの値が50以下の場合
        if(money <= 50)
        {
            Debug.Log("武器を売る");
        }
        //moneyが200以上の場合
        else if(money >= 200)
        {
            Debug.Log("武器を買う");
        }
        //変数moneyの値が上記以外の場合
        else
        {

            Debug.Log("ポーションを買う");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
