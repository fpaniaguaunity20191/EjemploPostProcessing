using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Sangre : MonoBehaviour
{
    PostProcessVolume ppv;//Componente
    Vignette vignetteLayer;//Seccion
    Grain grainLayer;
    private void Start()
    {
        ppv = GetComponent<PostProcessVolume>();//Obtenemos el componente
        ppv.profile.TryGetSettings(out vignetteLayer);//Cargamos la referencia a la seccion
        ppv.profile.TryGetSettings(out grainLayer);
    }
    void Update()
    {
        vignetteLayer.opacity.value += Time.deltaTime;
        if (vignetteLayer.opacity.value >= 1)
        {
            grainLayer.active = true;
        }
    }
}
