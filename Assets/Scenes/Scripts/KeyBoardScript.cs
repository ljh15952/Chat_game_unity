using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyBoardScript : MonoBehaviour
{
    public Text _text;

    public Text ExampleText;
    public MessegeManager MSGManager;

    public Image bar;
    float barpos;
    float addpos = 7f;
    private void Start()
    {
        StartCoroutine("barc");
        barpos = -126.2f;
    }

    IEnumerator barc()
    {
        while(true)
        {
            bar.gameObject.SetActive(!bar.IsActive());
            Debug.Log("ASD");
            yield return new WaitForSeconds(0.3f);
        }
    }

    public void GetClick()
    {
        barpos += addpos;
        bar.rectTransform.anchoredPosition = new Vector3(barpos, 31.38f, 0);
        _text.text += UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;
    }

    public void ClickBackBt()
    {
        barpos -= addpos;
        bar.rectTransform.anchoredPosition = new Vector3(barpos, 31.38f, 0);

        string a = "";
        for (int k = 0; k < _text.text.Length - 1; k++)
        {
            a += _text.text[k];
        }
        _text.text = a;
    }

    public void ClickEnterBt()
    {
        barpos = -126.2f;
        bar.rectTransform.anchoredPosition = new Vector3(barpos, 31.38f, 0);
        //단어 검사

        ExampleText.text = _text.text;
        MSGManager.CheckString(_text.text);
        _text.text = "";
    }

    public void ClickSpaceBt()
    {
        barpos += addpos;
        bar.rectTransform.anchoredPosition = new Vector3(barpos, 31.38f, 0);
        _text.text += " ";
    }
}
