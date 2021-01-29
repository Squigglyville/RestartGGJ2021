using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavPoint : MonoBehaviour
{
    private void Start()
    {
        GetComponent<MeshRenderer>().enabled = false;
    }
    private void OnEnable()
    {
        References.navpoints.Add(this);
    }

    // Update is called once per frame
    private void OnDisable()
    {
        References.navpoints.Remove(this);
    }
}
