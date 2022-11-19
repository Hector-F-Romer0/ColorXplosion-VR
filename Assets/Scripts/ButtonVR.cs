using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonVR : MonoBehaviour
{
    public GameObject button;
    public UnityEvent onPress;
    public UnityEvent onRelease;
    GameObject presser;
    AudioSource soundPressed;
    bool isPressed;

    GameObject[] greenDoors;
    GameObject[] orangeDoors;
    public string assigedColor;
    public Timer runTimer;
    public bool startGame = false;

    // Start is called before the first frame update
    void Start()
    {
        soundPressed = GetComponent<AudioSource>();
        isPressed = false;

        greenDoors = GameObject.FindGameObjectsWithTag("doorgreen");
        orangeDoors = GameObject.FindGameObjectsWithTag("doororange");
    }

    private void Update()
    {
        if (startGame == true)
        {
            startGame = runTimer.runTimerCanvas();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!isPressed)
        {
            button.transform.localPosition = new Vector3(0, 0.003f, 0);
            presser = other.gameObject;
            onPress.Invoke();
            soundPressed.Play();
            isPressed = true;
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject == presser)
        {
            button.transform.localPosition = new Vector3(0, 0.015f, 0);
            onRelease.Invoke();
            isPressed = false;
        }
    }

    public void spawnSphere()
    {
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        sphere.transform.localPosition = new Vector3(0, 1, 2);
        sphere.AddComponent<Rigidbody>();
        Debug.Log("HAS PRESIONADO EL BOTÓN");
    }

    public void toogleDoor()
    {

        if(assigedColor == "green")
        {
            foreach (GameObject gd in greenDoors)
            {
                if (gd.activeSelf)
                {

                    gd.SetActive(false);

                }
                else
                {

                    gd.SetActive(true);

                }

            }
        }
        else
        {
            foreach (GameObject gd in orangeDoors)
            {
                if (gd.activeSelf)
                {

                    gd.SetActive(false);

                }
                else
                {

                    gd.SetActive(true);

                }

            }
        }
    }

    public void runGame()
    {
        startGame = true;
        Debug.Log("Empieza el juego");
    }
}
