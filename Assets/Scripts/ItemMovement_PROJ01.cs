using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemMovement_PROJ01 : MonoBehaviour
{
    // Start is called before the first frame update
    private float Speed;
    public float MinSpeed;
    public float MaxSpeed;

    void Start()
    {
        Speed = Random.Range(MinSpeed, MaxSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, Speed * Time.deltaTime * - 1f, 0);
    }
}
