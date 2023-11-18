using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador : MonoBehaviour
{
    public Material postProcessingMaterial; // Asigna tu material desde el Inspector
    public float intensidad = 0;
    public AnimationClip clip;

    void Update() 
    {
        if (clip != null) 
        {
            postProcessingMaterial.SetFloat("_ShockWaveStrength", intensidad);
        }
    }
}
