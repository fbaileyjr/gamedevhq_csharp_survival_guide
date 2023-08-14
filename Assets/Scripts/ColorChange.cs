using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    private MeshRenderer _render;
    private WaitForSeconds _changeColorWait = new WaitForSeconds(3.0f);
    IEnumerator Start()
    {
        _render = GetComponent<MeshRenderer>();
        yield return StartCoroutine(ColorChangeRoutine());
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator ColorChangeRoutine ()
    {
        yield return _changeColorWait;
        _render.material.color = NewColor();
    }

    Color NewColor()
    {
        var color = new Color(Random.value, Random.value, Random.value);
        return color;
    }
}
