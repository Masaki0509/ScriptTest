using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;          // 体力
    private int power = 25; // 攻撃力
    private int mp = 53; //MP

    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }

    //魔法攻撃用の関数
    public void Magic()
    {
        // Magic関数内でmpを5減らし、コンソールに「魔法攻撃をした。残りMPは〇〇。」と表示してください。
        // 残りmpを減らす
        int m;
        this.mp -= 5;
        Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");

        // mpが足りない場合、「MPが足りないため魔法が使えない。」と表示してください

        this.mp -= 5 * 10;
            if (mp <= 0)
                Debug.Log("MPが足りないため魔法が使えない。");
        }
}

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 要素の個数が5の、int型の配列arrayを宣言して好きな値で初期化してください
        int[] array = new int[5];

        // 配列の各要素に値を代入する
        array[0] = 189;
        array[1] = 352;
        array[2] = 590;
        array[3] = 443;
        array[4] = 148;

        // for文を使い、配列の各要素の値を順番に表示してください
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }

        // for文を使い、配列の各要素の値を逆順に表示してください
        for (int j = 4; j >= 0; j--)
        {
            Debug.Log(array[j]);
        }

        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        // 攻撃用の関数を呼び出す
        lastboss.Attack();
        // 防御用の関数を呼び出す
        lastboss.Defence(3);

        // MP用の関数を呼び出す
        lastboss.Magic();


     }




    // Update is called once per frame
    void Update()
    {
        
    }
}
