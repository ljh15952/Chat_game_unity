﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MessegeManager : MonoBehaviour
{
    public Text _text;

    public bool istakepants;
    public bool isdooropen;
    public bool issit;

    int hentainum = 0;
    int fartnunm = 0;
    int pillnum = 0;

    public List<Sprite> Images;
    public Image GameBg;

    private void Start()
    {
        istakepants = true;
        isdooropen = false;
        issit = false;
    }

    public void CheckString(string str)
    {
        switch (str)
        {
            case "die":
            case "kill":
            case "kill myself":
                die();
                break;

            case "take off the pants":
            case "take off pants":
            case "get off the pants":
            case "get off pants":
            case "remove the pants":
            case "remove pants":
                take_off_pant();
                break;

            case "wear the pants":
            case "wear pants":
            case "get pants":
            case "take on pants":
                take_on_pant();
                break;

            case "shit":
                shit();
                break;

            case "sit on the toilet":
            case "sit toilet":
                sit();
                break;

            case "eat pill":
            case "eat medicine":
                eat_pill();
                break;

            case "pull door":
            case "pull the door":
                pull_door();
                break;

            case "open door":
            case "open the door":
                open_door();
                break;

            case "break door":
            case "break the door":
                break_door();
                break;

            case "push button":
            case "push the button":
                push_button();
                break;

            case "shut door":
            case "shut the door":
                shut_door();
                break;

            case "fart":
                fart();
                break;

            case "sex":
            case "boji":
            case "zaji":
            case "penis":
            case "dick":
            case "fuck":
            case "boob":
                hentai();
                break;
            default:
                _text.text = "IDK HOW TO " + str;
                break;
        }
    }

    void take_off_pant()
    {
        _text.text = "바지를 벗었습니다..";
        istakepants = false;

        GameBg.sprite = Images[0];
    }

    void take_on_pant()
    {
        _text.text = "바지를 입었습니다..";
        istakepants = true;

        GameBg.sprite = Images[1];

    }

    void shit()
    {
        if (issit)
        {
            if (istakepants)
            {
                _text.text = "변기에 앉았지만 바지에 똥을 쌋습니다..";

                GameBg.sprite = Images[2];
            }
            else
            {
                _text.text = "변기에 똥을 쌋습니다!!";

                GameBg.sprite = Images[3];
            }
        }
        else
        {
            if (istakepants)
            {
                _text.text = "바지에 똥을 쌋습니다..";

                GameBg.sprite = Images[2];
            }
            else
            {
                _text.text = "바닥에 똥을 쌋습니다..";

                GameBg.sprite = Images[4];
            }
        }
    }

    void sit()
    {
        if (isdooropen)
        {
            _text.text = "변기에 앉았습니다..";
            issit = true;

            GameBg.sprite = Images[5];

        }
        else
        {
            _text.text = "앉을 곳이 없습니다..";
        }
    }

    void eat_pill()
    {
        _text.text = "약을 먹었습니다..";
        pillnum++;
        if (pillnum >= 2)
        {
            //엔딩
            Debug.Log("엔딩");
        }
    }

    void shut_door()
    {
        if (isdooropen)
        {
            _text.text = "문을 닫았습니다!!";
            isdooropen = false;

            GameBg.sprite = Images[6];

        }
        else
        {
            _text.text = "문은 이미 닫혀있습니다..";
        }
    }

    void pull_door()
    {
        if (isdooropen)
        {
            _text.text = "이미 문을 열었습니다..";
        }
        else
        {
            _text.text = "문을 열었습니다!!";
            isdooropen = true;

            GameBg.sprite = Images[6];

        }
    }

    void open_door()
    {
        if (isdooropen)
        {
            _text.text = "이미 문을 열었습니다..";
        }
        else
        {
            _text.text = "문을 밀어봤지만 열리지 않는다..";
        }
    }

    void break_door()
    {
        if (isdooropen)
        {
            _text.text = "이미 문을 열었습니다..";
        }
        else
        {
            _text.text = "과격한 운동으로 똥을 싸버렸다..";

            //엔딩
            Debug.Log("엔딩");

            GameBg.sprite = Images[2];

        }
    }

    void die()
    {
        _text.text = "자살해버렸다..";

        //엔딩
        Debug.Log("엔딩");

        GameBg.sprite = Images[0];


    }

    void push_button()
    {
        _text.text = "버튼을 눌렀더니 약이 떨어졌다!!";
    }

    void hentai()
    {
        _text.text = "변태입니까?..";

        hentainum++;
        if (hentainum >= 3)
        {
            //엔딩
            Debug.Log("엔딩");
        }
    }

    void fart()
    {
        _text.text = "방구를 뀌니 살것같다!!";

        fartnunm++;
        if (fartnunm >= 3)
        {
            //엔딩
            Debug.Log("엔딩");
        }
    }
}
