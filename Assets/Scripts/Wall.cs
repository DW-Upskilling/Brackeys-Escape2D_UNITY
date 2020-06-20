using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public Rigidbody2D component;

    public float shrinkSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        component.rotation = Random.Range(0f, 360f);
        transform.localScale = Vector3.one * 5f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale -= Vector3.one * shrinkSpeed * Time.deltaTime;

        if(transform.localScale.x < 0.3f){
            Destroy(gameObject);
        }
    }
}
