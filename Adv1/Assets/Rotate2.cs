using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate2 : MonoBehaviour
{



    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(3 * Time.deltaTime, 5, 0);

      
    
    

    
    }
    private void OnTriggerEnter(Collider other)
    {
       
        if (other.tag=="MainCharacter")
        {

            Destroy(gameObject);

        }

    }




}




