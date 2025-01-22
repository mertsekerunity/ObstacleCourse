using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;

    int hits = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, 0, zValue);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            hits++;
            Debug.Log("Collided with: " + other.gameObject.name);
            Debug.Log("You have bumped into a thing this many times: " + hits);
            other.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
            //playerin cani azalsin, renk degistirme kalksin
        }
    }
}
