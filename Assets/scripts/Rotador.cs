using UnityEngine;

public class Rotador : MonoBehaviour
{
    [SerializeField]
    float rotacionY = 90f;
    
 

    // Usamos el Update pq es algo que se va a ir actualizando todo el rato a medida que jugemos 
    void Update()
    {
        transform.Rotate(0.0f, rotacionY * Time.deltaTime, 0f);
        
    }
}
