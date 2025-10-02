using TMPro;
using UnityEngine;

public class Temporizador : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timertext;
    [SerializeField]  float TiempoRestante;
    //si quito este serial el y pongo un mas el tiempo trans curre así se resta del tiempo restante

    void Update()
    {
        TiempoRestante -= Time.deltaTime;
        int minutos = Mathf.FloorToInt(TiempoRestante / 60);
        int segundos = Mathf.FloorToInt(TiempoRestante % 60);

        timertext.text = string.Format("{0:00}:{1:00}", minutos, segundos);
    }
}
