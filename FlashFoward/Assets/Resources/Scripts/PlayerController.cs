using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Transform self_trans;
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
        //Checking Status1　When　Step is NONE.
        if(next_step == STEP.NONE)
        {
            switch (step) {
                case STEP.RUN:
                    {
                        if (!is_running)
                        {
                            if(run_speed<= 0)
                            {
                                next_step = STEP.STOP;
                            }
                        }
                    }
                break;

                case STEP.MISS:
                    {
                        if (is_contact_floor)
                        {
                            next_step = STEP.RUN;
                        }
                    }
                break;
            }
            
        }

        //Checking Status2　When　Step is not NONE.
        if(next_step != STEP.NONE)
        {
            switch (next_step) {

                case STEP.STOP:
                    {

                    }
                    break;

                case STEP.MISS:
                    {
                        Vector3 velocity_ = this.GetComponent<Rigidbody>().velocity;
                        velocity_.x = -2.5f;
                        this.GetComponent<Rigidbody>().velocity = velocity_;

                    }
                    break;




            }

        }

    }


}
