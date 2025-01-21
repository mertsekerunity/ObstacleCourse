using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (gameObject.CompareTag("Obstacle"))
            {
                Debug.Log("Collided with: " + other.gameObject.name);
                GetComponent<MeshRenderer>().material.color = Color.red;
                //gameObject.tag = "Obstacle";
            }
        }
    }
}
