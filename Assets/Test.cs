using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //要素数5の配列を初期化
        int[] position = new int[5];

        //配列の各要素に値を格納
        position[0] = 30;
        position[1] = 20;
        position[2] = 50;
        position[3] = 10;
        position[4] = 80;

        //配列の要素をすべて表示する
        for(int i = 0; i < 5; i++)
        {
            Debug.Log(position[i]);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
