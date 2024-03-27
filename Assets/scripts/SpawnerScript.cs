using System.Collections;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject eat;
    private Vector2 randVector;
    private void Awake()
    {
        for (int i = 0; i < 1000; i++) 
        {
            randVector.Set(Random.Range(-99.5f, 99.5f), Random.Range(-99.5f, 99.5f));
            Instantiate(eat, randVector, Quaternion.identity);
        }
    }





}   
