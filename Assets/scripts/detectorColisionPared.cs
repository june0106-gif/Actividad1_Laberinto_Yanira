using UnityEngine;

public class detectorColisionPared : MonoBehaviour
{
    [SerializeField]
    Material materialColorDeLasParedes;

    [SerializeField]
    Material materialParedTocada;

    bool paredTocada = false;

    private void OnCollisionEnter(Collision col)
    {
        
        if (col.gameObject.tag == "Player")
        {
            //El punto hace que puedas acceder a esa ubicación
            Debug.Log(col.gameObject.name);
            //preguntar pq se pone el parentesis *****
            gameObject.GetComponent<MeshRenderer>().material = materialParedTocada;

            paredTocada = true;
        } 
    }
}
