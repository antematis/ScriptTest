using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //変数moneyを50で初期化
        int money = 50;
        //moneyの値が100以上の場合、「ポーションを買う」を表示する
        if(money >= 100)
        {
            Debug.Log("ポーションを買う");
        }
        //moneyが100未満の場合、「武器を売る」を表示する
        else
        {
            Debug.Log("武器を売る");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
