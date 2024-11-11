using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGeameController : MonoBehaviour
{
    public PlayerControler playerControler;
    public int iloscPunktowDoZebrania;
    public AudioSource audioSource;
    public AudioClip audioClip;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (playerControler.zebranePunkty == iloscPunktowDoZebrania)
            {
                audioSource.PlayOneShot(audioClip);
                Debug.Log("Zebrano wszystkie punkty. Koniec gry");
            }
        }
    }
}
