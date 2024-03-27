using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector2 mousePosition;
    private float quotient;
    private float delta;
    public float mass;
    private Vector2 randVec;
    

    // Start is called before the first frame update
    void Start()
    {
        mass = 10;
        delta = 5;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        mousePosition -= (Vector2)transform.position;
        quotient = Mathf.Sqrt(mousePosition.x * mousePosition.x + mousePosition.y * mousePosition.y) / delta;
        mousePosition /= quotient;
        transform.Translate(mousePosition * Time.deltaTime);
        
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Eat")
        {
            mass += 10;
            randVec.Set(Random.Range(-99.5f, 99.5f), Random.Range(-99.5f, 99.5f));
            col.gameObject.transform.position = randVec;
        }
    }
}
