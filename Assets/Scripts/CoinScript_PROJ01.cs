using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinScript_PROJ01 : MonoBehaviour
{
    public int coinValue;
    public TextMeshPro valueText;
    public SpriteRenderer sr;


    float FallSpeed;

    // Start is called before the first frame update
    void Start()
    {
        FallSpeed = Random.Range(0.01f, 0.05f);
        //sr = GetComponent<SpriteRenderer>();

        //ChangeCoinColor(Random.ColorHSV());
        //ChangeCoinValue(Random.Range(1, 9));
    }

    private void Update()
    {
        transform.Translate(0.05f * Time.deltaTime * 0, -FallSpeed, 0);
    }

    //public void ChangeCoinColor(Color c)
    //{
    //    sr.color = c;
    //}

    public void ChangeCoinValue(int v)
    {
        coinValue = v;
        valueText.text = coinValue.ToString();
    }


}
