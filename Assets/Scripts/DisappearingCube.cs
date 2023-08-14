using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearingCube : MonoBehaviour
{
    public bool isInvisible = false;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I) && isInvisible == false)
        {
            StartCoroutine("TurnCubeInvisible");
        }

    }

    IEnumerator TurnCubeInvisible()
    {
        this.gameObject.GetComponent<MeshRenderer>().enabled = false;
        isInvisible = true;
        yield return new WaitForSeconds(5.0f);
        isInvisible = false;
        this.gameObject.GetComponent<MeshRenderer>().enabled = true;
    }
}
