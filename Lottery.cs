using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lottery : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float LotteryPos(float Pos)
    {
        if (Pos >= -16.94 && Pos < -21.86)
        {
            return -19.4f;
        }
        else if (Pos < -12.015 && Pos >= -16.94)
        {
            return -14.475f;
        }
        else if (Pos < -7.09 && Pos >= -12.015)
        {
            return -9.55f;
        }
        else if (Pos < -2.165 && Pos >= -7.09)
        {
            return -4.625f;
        }
        else if (Pos >= -2.165 && Pos < 2.16)
        {
            return 0.3f;
        }
        else if (Pos >= 2.16 && Pos < 7.685)
        {
            return 5.225f;
        }
        else if (Pos >= 7.685 && Pos < 12.61)
        {
            return 10.15f;
        }
        else if (Pos >= 12.61 && Pos < 17.535)
        {
            return 15.075f;
        }
        else return 20f;
    }
}
