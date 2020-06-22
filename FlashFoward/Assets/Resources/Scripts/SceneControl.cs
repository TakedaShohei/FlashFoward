using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneControl : MonoBehaviour
{

    public enum STEP
    {

        NONE = -1,

        START,                  // 『はじめ！』の文字が出てる間.
        GAME,                   // ゲーム中.
        ONI_VANISH_WAIT,        // タイムオーバー後、画面にいるオニがいなくなるのを待つ.
        LAST_RUN,               // オニが出現しなくなってからしばらく進む.
        PLAYER_STOP_WAIT,       // プレイヤーが止まるのを待ってる.

        GOAL,                   // ゴール演出.
        ONI_FALL_WAIT,          // 『上からおにが降ってくる』演出が終わるのをまつ.
        RESULT_DEFEAT,          // 倒した数の評価表示.
        RESULT_EVALUATION,      // 倒したタイミングの評価表示.
        RESULT_TOTAL,           // 総合評価.

        GAME_OVER,              // ゲームオーバー.
        GOTO_TITLE,             // タイトルへ移行.

        NUM,
    };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
