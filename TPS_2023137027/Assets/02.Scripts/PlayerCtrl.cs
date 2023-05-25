using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    
    private Transform tr;

    
    private Animation anim;

    
    public float moveSpeed = 10.0f;


    public float turnSpeed = 80.0f;
    
    
private readonly float initHp = 100.0f;

public float currHp;


public delegate void PlayerDieHandler();

public static event PlayerDieHandler OnPlayerDie;
    
 


    

    
    
    
    void Start()
    {
        
        tr = GetComponent<Transform>();
        anim = GetComponent<Animation>();
      
        anim.Play("Idle");
        currHp = initHp;
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");      // -1.0f ~ 0.0f ~ +1.0f
        float v = Input.GetAxis("Vertical");        // -1.0f ~ 0.0f ~ +1.0f
        float r = Input.GetAxis("Mouse X");

       
        Vector3 moveDir = (Vector3.forward * v) + (Vector3.right * h);

        
        tr.Translate(moveDir.normalized * Time.deltaTime * moveSpeed);

        
        tr.Rotate(Vector3.up * turnSpeed * Time.deltaTime * r);

        
        PlayerAnim(h, v);
    }
    
    
    void OnTriggerEnter(Collider coll)
{

if (currHp >= 0.0f && coll.CompareTag("PUNCH"))
{
currHp -= 10.0f;
Debug.Log($"Player hp = {currHp / initHp}");
if (currHp <= 0.0f)
{
PlayerDie();
}
}
}

void PlayerDie()
{
Debug.Log("Player Die !");

OnPlayerDie();
}
   
  


  



    void PlayerAnim(float h, float v)
    {
       
        if (v >= 0.1f)
        {
            anim.CrossFade("RunF", 0.25f);
        }
        else if (v <= -0.1f)
        {
            anim.CrossFade("RunB", 0.25f);
        }
        else if (h >= 0.1f)
        {
            anim.CrossFade("RunR", 0.25f);
        }
        else if (h <= -0.1f)
        {
            anim.CrossFade("RunL", 0.25f);
        }
        else
        {
            anim.CrossFade("Idle", 0.25f);   
        }
    }
}
