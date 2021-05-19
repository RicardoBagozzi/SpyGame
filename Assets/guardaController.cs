using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guardaController : MonoBehaviour
{
    public float velocidadeRotacao = 2.0f;
    public float amplitudeRotacao = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        RaycastHit hit;

        transform.eulerAngles += new Vector3(0.0f, 
                                            amplitudeRotacao * Mathf.Sin(velocidadeRotacao * Time.realtimeSinceStartup),
                                            0.0f);

        if( Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity) )
        {
            
            if (hit.transform.tag == "Player")
            {
                // Gizmos.color = Color.red;
                Debug.DrawLine(transform.position, hit.point, Color.red);
                // Gizmos.DrawLine(transform.position, hit.point);
                Debug.LogWarning("Achei o player.");
            }
            else
            {
                Debug.DrawLine(transform.position, hit.point, Color.blue);
                // Gizmos.color = Color.green;
                // Gizmos.DrawLine(transform.position, transform.position*1000);
            }
            
        }
        else
        {
            Debug.DrawLine(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.green);
        }
    }
}
