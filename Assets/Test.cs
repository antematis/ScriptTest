using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    //第一引数と第二引数の値を加算した値を返す関数
    int Add(int a, int b)
    {
        //第一引数と第二引数の値を加算して、変数cに格納する
        int c = a + b;
        //変数cを呼び出し元の関数に返す
        return c;
    }
    // Start is called before the first frame update
    void Start()
    {
        //Add関数に「3」と「6」の引数を渡し、返り値をnum変数に格納
        int num = Add(3, 6);
        //numを表示する
        Debug.Log(num);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
