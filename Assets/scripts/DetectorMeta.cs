using TMPro;
using UnityEngine;

public class DetectorMeta : MonoBehaviour
{
    [SerializeField]
    GameObject pantallaFinal;

    [SerializeField]
    TextMeshProUGUI textLabelTime;

    float TiempoDeParida = 0.0f;
    bool estaJugando = true; 
    //se pone ontrige porque le activamos el is trigger.
    private void OnTriggerEnter(Collider other)
    {
        //Recordatorio si no pones La P mayuscula no va a funcionar AAAAAAAAAAAAAA
        if (other.tag == "Player")
        {
            Debug.Log("Jugador llegó a la meta");
            pantallaFinal.SetActive(true);
            other.GetComponent<movimientoJugador>().enabled = false;
            Debug.Log(TiempoDeParida);
            textLabelTime.text = TiempoDeParida.ToString();
        }
    }

    private void Update()
    {
        if (estaJugando == true)
        {
            TiempoDeParida = TiempoDeParida + Time.deltaTime;
            
        }

    }

}
