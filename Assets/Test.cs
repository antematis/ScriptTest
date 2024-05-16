using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //sumを0で初期化する
        int sum = 0;
        //10回処理を繰り返す
        for(int i = 0; i <= 10; i++)
        {
            //iの値をsumに加算する
            sum += i;
        }
        //sumの値を表示する
        Debug.Log(sum);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
