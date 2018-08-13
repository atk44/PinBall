using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{

    //ボールが見える可能性のあるz軸の最大値
    private float visiblePosZ = -6.5f;
    //プレイヤーの得点
    private int point = 0;
    //的の得点（SmallStar,LargeStar,SmallCloud,LargeCloud）
    private int smallStar = 100;
    private int largeStar = 500;
    private int smallCloud = 200;
    private int largeCloud = 2000;

    //ゲームオーバを表示するテキスト
    private GameObject gameoverText;
    //得点を表示するテキスト
    private GameObject scoreText;

    //スコアを計算する関数、BrightnessRegulatorから呼び出し
    public void hitSmallStar()
    {
        this.point += smallStar;
    }
    public void hitLargeStar()
    {
        this.point += largeStar;
    }
    public void hitSmallCloud()
    {
        this.point += smallCloud;
    }
    public void hitLargeCloud()
    {
        this.point += largeCloud;
    }


    // Use this for initialization
    void Start()
    {
        //シーン中のGameOverTextオブジェクトを取得
        this.gameoverText = GameObject.Find("GameOverText");
        this.scoreText = GameObject.Find("ScoreText");
    }

    // Update is called once per frame
    void Update()
    {
        //ボールが画面外に出た場合
        if (this.transform.position.z < this.visiblePosZ)
        {
            //GameoverTextにゲームオーバを表示
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }

        //スコアの表示
        this.scoreText.GetComponent<Text>().text = this.point.ToString() + "point";
    }
}