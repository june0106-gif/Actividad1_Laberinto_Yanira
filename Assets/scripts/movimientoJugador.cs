using UnityEngine;

public class movimientoJugador : MonoBehaviour
{


    public float movimientoEjeX;
    public float movimientoEjeY;
    public float movimientoEjeZ;

    //si es una variable float, cuando le añadiamos un valor siempre se le pone una f 
    public float velocidadMovimiento = 1.5f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Izquierda y derecha es EjeX A y D
        //Arriba y abajo EjeZ W y S

        // anotación * Time.deltaTime = se usa para que aunque uno tenga un pc que de tirones o el flipado de la nasa puedan ir a la misma velocidad independientemente al dispositivo que tengan

        //Si se me invirtieran los controles se podria ponmer un - delante del input para reinvertirlos 
        movimientoEjeX = Input.GetAxis("Horizontal") * Time.deltaTime * velocidadMovimiento;
        movimientoEjeZ = Input.GetAxis("Vertical") * Time.deltaTime * velocidadMovimiento;

        transform.Translate(movimientoEjeX, movimientoEjeY, movimientoEjeZ);
    }
}
