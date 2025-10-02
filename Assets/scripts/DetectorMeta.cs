using UnityEngine;

public class DetectorMeta : MonoBehaviour
{
    [SerializeField]
    GameObject pantallaFinal;
    //se pone ontrige porque le activamos el is trigger.
    private void OnTriggerEnter(Collider other)
    {
        //Recordatorio si no pones La P mayuscula no va a funcionar AAAAAAAAAAAAAA
        if (other.tag == "Player")
        {
            Debug.Log("Jugador llegó a la meta");
            pantallaFinal.SetActive(true);
            other.GetComponent<movimientoJugador>().enabled = false;
        }
    }

}
