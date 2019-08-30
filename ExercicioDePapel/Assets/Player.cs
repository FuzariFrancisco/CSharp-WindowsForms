using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    SpriteRenderer player;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {
            transform.Translate(Vector3.right * 0.15f);
            player.flipX = false;
        }
        if (Input.GetAxis("Horizontal") < 0)
        {
            transform.Translate(Vector3.left * 0.15f);
            player.flipX = true;
        }

        if (Input.GetAxis("Vertical") > 0)
        {
            transform.Translate(Vector3.up * 0.15f);
        }
        if (Input.GetAxis("Vertical") < 0)
        {
            transform.Translate(Vector3.down * 0.15f);
        }

        float posY = transform.position.y;
        float posX = transform.position.x;

        if (transform.position.x > 12.87f)
        {
            transform.position = new Vector2(-12.89f, posY);
        }
        if (transform.position.x < -12.89f)
        {
            transform.position = new Vector2(12.87f, posY);
        }

        if (transform.position.y > 6.53f)
        {
            transform.position = new Vector2(posX, - 6.55f);
        }
        if (transform.position.y < -6.55f)
        {
            transform.position = new Vector2(posX, 6.53f);
        }

    }
}
