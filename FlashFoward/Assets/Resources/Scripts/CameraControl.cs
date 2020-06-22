using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [SerializeField] GameObject player_ = null;
    public Vector3 offset_;
    [SerializeField] Transform self_trans;
    
    // Start is called before the first frame update
    void Start()
    {
        player_ = GameObject.FindGameObjectWithTag("Player");
        offset_ = self_trans.position - player_.transform.position;
    }


    // Update is called once per frame
    void Update()
    {
        self_trans.position = new Vector3(player_.transform.position.x + offset_.x, player_.transform.position.y + offset_.y, self_trans.position.z);
    }
}
