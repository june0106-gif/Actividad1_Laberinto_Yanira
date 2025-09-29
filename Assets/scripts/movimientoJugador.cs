using UnityEngine;

public class movimientoJugador : MonoBehaviour
{


    public float movimientoEjeX;
    public float movimientoEjeY;
    public float movimientoEjeZ;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(movimientoEjeX, movimientoEjeX, movimientoEjeZ);
    }
}
