using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class door : MonoBehaviour
{
    private float tempo = 0, tempoDeTransicao = 0.02f;
    private int inversor = 1;
    private float deslocamento = 0, posicaoIncialEm_y;
    private bool parada = true;
    public GameObject victory_panel;

    // Use this for initialization
    void Start()
    {
        deslocamento = 8.5f;
        posicaoIncialEm_y = transform.position.y;

    }

    // Update is called once per frame
    void Update()
    {
        tempo += Time.deltaTime;
        posicao();

    }

    public void posicao()
    {
        if (tempo > 0.005f && inversor == -1 && transform.position.y < deslocamento && parada == false)
        {

            transform.position = new Vector3(transform.position.x, transform.position.y + tempoDeTransicao, transform.position.z);
            tempo = 0;

            if (transform.position.y >= deslocamento)
            {
                inversor = 1;
                parada = true;
                tempo = 0;
            }


        }

        if (inversor == 1f && parada == true && tempo >= 1.5f)
        {
            parada = false;
            tempo = 0;
        }


        if (inversor == 1f && parada == false && tempo > 0.005f && transform.position.y > posicaoIncialEm_y)
        {

            transform.position = new Vector3(transform.position.x, transform.position.y - tempoDeTransicao, transform.position.z);
            tempo = 0;

        }





    }

    void OnTriggerEnter(Collider cs)
    {

        if (cs.gameObject.tag == "Player")
        {
            inversor = -1;
            Time.timeScale = 0;
            parada = false;
            victory_panel.SetActive(true);
        }
    }
}