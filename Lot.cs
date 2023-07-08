using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lot : MonoBehaviour
{
    public int Lv = 1;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        ClearText.SetActive(false);
        ClearText2.SetActive(false);
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public float LotteryPos()
    {
        float random = Random.value;
        if (Lv == 1)
        {
            if (random >= 0 && random < 0.11)
            {
                hantei(1);
                return -19.4f;
            }
            else if (random >= 0.11 && random < 0.22)
            {
                hantei(2);
                return -14.475f;
            }
            else if (random >= 0.22 && random < 0.33)
            {
                hantei(3);
                return -9.55f;
            }
            else if (random >= 0.33 && random < 0.44)
            {
                hantei(4);
                return -4.625f;
            }
            else if (random >= 0.44 && random < 0.55)
            {
                hantei(5);
                return 0.3f;
            }
            else if (random >= 0.55 && random < 0.66)
            {
                hantei(6);
                return 5.225f;
            }
            else if (random >= 0.66 && random < 0.77)
            {
                hantei(7);
                return 10.15f;
            }
            else if (random >= 0.77 && random < 0.88)
            {
                hantei(8);
                return 15.075f;
            }
            else
            {
                hantei(9);
                return 20f;
            }
        }

        else if(Lv == 2)
        {
            if (random >= 0 && random < 0.14)
            {
                hantei(2);
                return -14.475f;
            }
            else if (random >= 0.14 && random < 0.28)
            {
                hantei(3);
                return -9.55f;
            }
            else if (random >= 0.28 && random < 0.42)
            {
                hantei(4);
                return -4.625f;
            }
            else if (random >= 0.42 && random < 0.56)
            {
                hantei(5);
                return 0.3f;
            }
            else if (random >= 0.56 && random < 0.70)
            {
                hantei(6);
                return 5.225f;
            }
            else if (random >= 0.70 && random < 0.84)
            {
                hantei(7);
                return 10.15f;
            }
            else
            {
                hantei(8);
                return 15.075f;
            }
        }

        if (Lv == 3)
        {
            if (random >= 0 && random < 0.33)
            {
                hantei(6);
                return 5.225f;
            }
            else if (random >= 0.33 && random < 0.66)
            {
                hantei(7);
                return 10.15f;
            }
            else
            {
                hantei(8);
                return 15.075f;
            }
        }

        else {
            hantei(7);
            return 10.15f;
        }
    }

    private int i = 0;
    private int slot1 = 0;
    private int slot2 = 0;
    private int slot3 = 0;
    public GameObject ClearText;
    public GameObject ClearText2;

    private void hantei(int No)
    {
        if(i == 0)
        {
            slot1 = No;
            i++;
            Debug.Log("1");
            print(slot1);
            return;
        }

        if (i == 1)
        {
            slot2 = No;
            i++;
            Debug.Log("2");
            print(slot2);
            return;
        }

        if (i == 2)
        {
            slot3 = No;
            Debug.Log("3");
            print(slot3);
            if (slot1 == slot2 && slot2 == slot3)
            {
                ClearText.SetActive(true);
                Debug.Log("omedetou");
                i = 0;
                audioSource.Play();
                return;
            }
            if (slot1 == slot2 || slot2 == slot3 || slot1 == slot3)
            {
                ClearText2.SetActive(true);
                Debug.Log("osii");
                i = 0;
                return;
            }

            i = 0;
        }
    }

    public void LvUp()
    {
        Lv++;
    }
}
