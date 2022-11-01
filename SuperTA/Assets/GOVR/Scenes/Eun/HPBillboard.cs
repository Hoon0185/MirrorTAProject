using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPBillboard : MonoBehaviour
{
    public Transform cam;

    private void Update()
    {
        transform.LookAt(transform.position +  cam.forward);
    }
}

