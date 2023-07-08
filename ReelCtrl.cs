using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReelCtrl : MonoBehaviour
{
    public bool StartButtonFlag;
    public bool StopButtonFlag;

    public GameObject Reel;

    private Vector3 StartPos;

    public Lot lottery;

    // Start is called before the first frame update
    void Start()
    {
        StartButtonFlag = false;
        StopButtonFlag = false;
        StartPos = Reel.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(StopButtonFlag)
        {
                StartButtonFlag = false;
                StopButtonFlag = false;
                Reel.transform.position = new Vector3(StartPos.x, lottery.LotteryPos(), 0);
        }

        if(StartButtonFlag)
        {
            Reel.transform.Translate(0, 2f, 0);
            if(Reel.transform.position.y > 22.46f)
            {
                Reel.transform.position = new Vector3(StartPos.x, -21.86f, 0);
            }
        }
    }

    
}
