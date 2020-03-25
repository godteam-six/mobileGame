using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour
{

    private int isforward;//标记摄像机的移动方向
    //记录两个手指的旧位置
    private Vector2 oposition1 = new Vector2();
    private Vector2 oposition2 = new Vector2();

    Vector2 m_screenPos = new Vector2(); //记录手指触碰的位置

    void Start()
    {
        Input.multiTouchEnabled = true;//开启多点触碰
    }

    void Update()
    {
        if (Input.touchCount <= 0)
            return;
        if (Input.touchCount == 1) //单点触碰移动摄像机
        {
            if (Input.touches[0].phase == TouchPhase.Began)
                m_screenPos = Input.touches[0].position;   //记录手指刚触碰的位置
            if (Input.touches[0].phase == TouchPhase.Moved) //手指在屏幕上移动，移动摄像机
            {
                transform.Translate(new Vector3(-Input.touches[0].deltaPosition.y * Time.deltaTime*1.5f , 0, Input.touches[0].deltaPosition.x * Time.deltaTime*1.5f),Space.World);
                
            }
        }
    }
}