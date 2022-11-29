using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class VRButton : MonoBehaviour
{
    public GameObject button;
    public Rigidbody Sodacan;
    public Transform Spawnpoint;
    public UnityEvent onPress;
    public UnityEvent onRelease;
    GameObject presser;
    AudioSource sound;
    bool isPressed; 

    // Start is called before the first frame update
    void Start()
    {
        sound = GetComponent<AudioSource>();
        isPressed = false;
    }

    private void OnTriggerEnter(Collider other) {
        if(!isPressed){
            presser = other.gameObject;
            onPress.Invoke();
            sound.Play();
            isPressed = true;
        }
    }

    private void OnTriggerExit(Collider other) {
        if(other.gameObject == presser){
            onRelease.Invoke();
            isPressed = false;
        }
    }

    public void SpawnCans() {
        Rigidbody Rigidcan;
        Rigidcan = Instantiate(Sodacan, Spawnpoint.position, Quaternion.Euler(new Vector3(45, 0, 0))) as Rigidbody;
    }
}
