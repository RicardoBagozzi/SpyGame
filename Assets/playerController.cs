using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerController : MonoBehaviour
{
    Vector3 moveVec = new Vector3(0, 0, 0);
    public float velocidade = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.transform.position += moveVec;
    }

    public void OnMove(InputValue input)
    {
        moveVec = new Vector3(velocidade * input.Get<Vector2>().x, 
                                0, 
                                velocidade * input.Get<Vector2>().y);
    }
}
