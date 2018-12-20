using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public Text counterText;

    public float tempo_da_caixa = Settings.TempoCaixas;

    public float seconds;

    void Start () {
        counterText = GetComponent<Text>() as Text;
    }

    void Update () {
        seconds = (int) tempo_da_caixa - ((Time.timeSinceLevelLoad % 60f) % tempo_da_caixa);
        if (seconds.ToString("00") != "00") {

            if (seconds < 5)
                counterText.color = new Color(1f, 0.0f, 0.0f);

            counterText.text = seconds.ToString("00");

        } else { 
            counterText.text = "--";
            counterText.color = new Color(0f, 0f, 0f);
        }

    }

}