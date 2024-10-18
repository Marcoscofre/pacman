using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio_unico : MonoBehaviour
{
    void Awake()
    {
        // Obtiene todos los AudioListeners en la escena
        AudioListener[] listeners = FindObjectsOfType<AudioListener>();

        // Si hay más de uno, desactiva todos excepto el primero
        for (int i = 1; i < listeners.Length; i++)
        {
            listeners[i].enabled = false;
        }
    }
}
