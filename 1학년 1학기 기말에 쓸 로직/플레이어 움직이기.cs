using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lil : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    
        
    }

    // Update is called once per frame
    void Update()
    {
    // 왼쪽 화살표가 눌렸을 때
    if(Input.GetKeyDown(KeyCode.LeftArrow))
    {
    transform.Translate(-3,0,0); // 왼쪽으로 3 움직인다
    }

    if(Input.GetKeyDown(KeyCode.RightArrow))
    {
    transform.Translate(3,0,0); // 오른쪽으로 3 움직인다
    }
        
    }
}
