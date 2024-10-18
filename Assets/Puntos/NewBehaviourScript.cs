using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    // Valor fijo en el eje Y
    private float fixedY = 2.31f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Mantener la posición del objeto fija en el eje Y
        transform.position = new Vector3(transform.position.x, fixedY, transform.position.z);
    }
}
