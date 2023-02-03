using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerPlacer : MonoBehaviour
{
    bool obstructed = false;

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition); //get current mouse position

        transform.position = new Vector3(mousePos.x, mousePos.y, transform.position.z);

    }

    void OnFire(){
        if (obstructed)
        {
            Debug.Log("Obstructed!");
        } 
        else
        {
            Debug.Log("Can place!");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Triggered");
        if (collision.gameObject.CompareTag("Path"))
        {
            obstructed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Path"))
        {
            obstructed = false;
        }
    }
}
