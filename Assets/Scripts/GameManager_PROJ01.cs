using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager_PROJ01 : MonoBehaviour
{
    private float widthValue = 8;
    public GameObject[] Items;
    void Start()
    {
        InvokeRepeating("RndItem", 1, 1f);
    }

    void Update()
    {
        
    }

    void RndItem()
    {
        float randomXValue = Random.Range(-widthValue, widthValue);

        Vector3 pos = new Vector3(randomXValue, 8f, 0);
        var i = Items[Random.Range(0, Items.Length)];
        Instantiate(i, pos, Quaternion.identity);
    }
}
