using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager_PROJ01 : MonoBehaviour
{
    public GameObject coinPrefab;
    private float heightValue = 4;
    private float widthValue = 8;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnCoin", 4, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnCoin()
    {
        float randomXValue = Random.Range(-widthValue, widthValue);
        //float randomYValue = Random.Range(-heightValue, heightValue);

        Vector3 pos = new Vector3(randomXValue, 5.5f, 0);
        GameObject coin = Instantiate(coinPrefab, pos, Quaternion.identity);

        CoinScript_PROJ01 coinScript = coin.GetComponent<CoinScript_PROJ01>();

        int rndValue = Random.Range(0, 3);
        coinScript.ChangeCoinValue(rndValue);
        //coinScript.ChangeCoinColor(coinColors[rndValue]);

    }
}
