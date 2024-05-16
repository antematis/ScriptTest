using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    //体力
    private int hp = 100;
    //攻撃力
    private int power = 25;
    //MP
    private int mp = 53;
    //魔法を使うときのMPの消費値
    private const int consumeMp = 5;

    //攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    //魔法を使用する
    public void Magic()
    {
        //現在のMPの値が消費されるMP値以上の場合
        if(consumeMp <= this.mp)
        {
            this.mp -= consumeMp;
            Debug.LogFormat("魔法攻撃をした。残りMPは{0}。", this.mp);
        }
        //現在のMPが消費されるMP値よりも少ない場合
        else
        {
            Debug.Log("MPが足りないため、魔法が使えない。");
        }
    }

    //防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        //残りhpを減らす
        this.hp -= damage;
    }
}

public class Test : MonoBehaviour
{
    //配列arrayに整数値を格納した状態で初期化
    int[] array = { 0, 100, 25, 53, 11};
    // Start is called before the first frame update
    void Start()
    {
        //配列arrayの各要素を先頭から順番に表示する
        for(int i = 0; i < array.Length; i++)   Debug.Log(array[i]);
        //配列arrayの各要素を最後尾から逆順に表示する
        for (int i = array.Length - 1; 0 <= i; i--) Debug.Log(array[i]);

        //Bossクラスのインスタンスを生成
        Boss lastboss = new Boss();
        //Bossクラスインスタンスlastbossの関数Magic()を10回呼び出す
        for (int i = 0; i < 10; i++)
        {
            lastboss.Magic();
        }
        //Bossクラスインスタンスlastbossの関数Magic()を呼び出す
        lastboss.Magic();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
