using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UICtrl : MonoBehaviour
{
    public ReelCtrl reel1;
    public ReelCtrl reel2;
    public ReelCtrl reel3;

    public bool isStop1;
    public bool isStop2;
    public bool isStop3;

    public Text LvText;

    public Lot lot;

    public GameObject ClearText;
    public GameObject ClearText2;

    public AudioClip pressSE;
    public AudioClip startSE;
    public AudioClip kakinSE;

    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        isStop1 = true;
        isStop2 = true;
        isStop3 = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PressStart()
    {
        if (isStop1 && isStop2 && isStop3)
        {
            isStop1 = false;
            isStop2 = false;
            isStop3 = false;

            reel1.StartButtonFlag = true;
            reel2.StartButtonFlag = true;
            reel3.StartButtonFlag = true;

            ClearText.SetActive(false);
            ClearText2.SetActive(false);

            Debug.Log("start");
            audioSource.PlayOneShot(startSE);
        }
    }

    public void PressStop1()
    {
        if (isStop1 == false)
        {
            reel1.StopButtonFlag = true;
            audioSource.PlayOneShot(pressSE);
            isStop1 = true;
        }
    }

    public void PressStop2()
    {
        if (isStop2 == false)
        {
            reel2.StopButtonFlag = true;
            audioSource.PlayOneShot(pressSE);
            isStop2 = true;
        }
    }

    public void PressStop3()
    {
        if (isStop3 == false)
        {
            reel3.StopButtonFlag = true;
            audioSource.PlayOneShot(pressSE);
            isStop3 = true;
        }
    }

    public void PressKakin()
    {
        lot.LvUp();
        LvText.text = "â€ã‡Lv." + lot.Lv;
        if(lot.Lv >= 4)
        {
            LvText.text = "â€ã‡Lv.Max";
        }
        audioSource.PlayOneShot(kakinSE);

    }
}
