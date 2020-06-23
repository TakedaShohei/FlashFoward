using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    public float run_speed = 5.0f;

    [SerializeField] float run_max_ = 20.0f;

    protected const float run_add_ = 5.0f;

    protected bool is_running = true;
    protected bool is_contact_floor = false;
    protected bool is_playable = true;

    public enum STEP
    {

        NONE = -1,

        RUN = 0,        // 走る　　ゲーム中.
        STOP,           // 止まる　ゴール演出時.
        MISS,           // ミス　　おににぶつかったしたとき.
        NUM,
    };

    public STEP step = STEP.NONE;
    public STEP next_step = STEP.NONE;
    
    // Use this for initialization
    void Start()
    {
        run_speed = 0;

        next_step = STEP.RUN;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
