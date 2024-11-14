using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionItemm : MonoBehaviour
{
    public PlayerControler playerControler;
    public AudioSource audioSource;
    public AudioClip audioClip;
    public MeshRenderer meshRenderer;
    public CapsuleCollider capsuleCollider;
    public MuffinController muffinController;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        meshRenderer = GetComponent<MeshRenderer>();
        capsuleCollider = GetComponent<CapsuleCollider>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            playerControler.zebranePunkty++;
            Debug.Log(playerControler.zebranePunkty);
            audioSource.PlayOneShot(audioClip);
            meshRenderer.enabled = false;
            capsuleCollider.enabled = false;
            muffinController.meshRenderer.enabled = false;

            //Destroy(this.gameObject);
        }
    }
}