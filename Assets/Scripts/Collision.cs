using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Auch!");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

    }

    private void OnTriggerExit2D(Collider2D other)
    {

    }

    private void OnTriggerStay2D(Collider2D other)
    {

    }



}
