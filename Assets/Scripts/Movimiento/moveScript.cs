using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class moveScript : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 0;
    
    Vector2 rotation = new Vector2 (0, 0);
    public float speed = 3;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed);
        transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed, 0, 0);
    }
}
