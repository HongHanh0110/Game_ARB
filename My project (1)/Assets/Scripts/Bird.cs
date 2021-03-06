using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    Vector3 InitialPos;
    public Rigidbody2D rb;
    private void Start() 
    {
        InitialPos = transform.position;
    }
    private void OnMouseDrag()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(mousePos.x, mousePos.y,0);
    }
    private void OnMouseUp()
    {
        Vector3 vectorForce = InitialPos - transform.position;
        GetComponent<Rigidbody2D>().AddForce(vectorForce*300);
        GetComponent<Rigidbody2D>().gravityScale = 1;
    }

}
