using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float velocidade = Random.Range(0.0001f, 0.1f);

        transform.Translate(Vector3.down * velocidade);

        float posX = transform.position.x;

        if(transform.position.y < -5.62f)
        {
            transform.position = new Vector2(posX, 5.61f);
        }
    }
}
