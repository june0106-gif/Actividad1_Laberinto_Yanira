using UnityEngine;

public class detectorColisionPared : MonoBehaviour
{
    [SerializeField]
    Material materialPorDefecto;

    [SerializeField]
    Material materialParedTocada;

    bool paredRoja = false;

    float tiempoEnRojo = 2.5f;

    private void Update()
    {
        if (paredRoja == true)
        {
            //para contar tiempo necesitamos una variable tipo float
            tiempoEnRojo = tiempoEnRojo - Time.deltaTime;
            // el delta time sirve siver para mantener siempre la misma velocidad en cualquier ordenador por ejemplo.
            if (tiempoEnRojo < 0.0f)
            {
                gameObject.GetComponent<MeshRenderer>().material = materialPorDefecto;

                paredRoja = false; //deja de contar

                //Cuando se ponga el condicional para un tiempo determinado tambien es obligatorio por el tiempo que tarda en volver a la normalidad.

                tiempoEnRojo = 2.5f;

            }
        }
    }

    private void OnCollisionEnter(Collision col)
    {
        
        if (col.gameObject.tag == "Player")
        {
            //El punto hace que puedas acceder a esa ubicación
            Debug.Log(col.gameObject.name);
            //se ponen el mayor y el menor que, luego se le pone el nombre del componente en este caso es el meshrenderer y luego parenteis y punto, es así pq si.
            gameObject.GetComponent<MeshRenderer>().material = materialParedTocada;

            paredRoja = true;
        }  
    }
}
