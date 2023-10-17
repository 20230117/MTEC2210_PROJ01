using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager_PROJ01 : MonoBehaviour
{
    public static ScoreManager_PROJ01 instance;
    public Text score;
    int s = 0;

    // Start is called before the first frame update
    void Start()
    {
        score.text = s.ToString();
    }

    private void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddPoint()
    {
        s ++;
        score.text = s.ToString();
    }
}
