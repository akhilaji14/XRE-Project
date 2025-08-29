using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CaliperSlideManual : MonoBehaviour
{
    [SerializeField] private float xLimit = 0.1564f; // Local space offset of the slide stopper on the model

    void Update()
    {
        float clampedX = Mathf.Clamp(transform.localPosition.x, 0f, xLimit);
        transform.localPosition = new Vector3(clampedX, transform.localPosition.y, transform.localPosition.z);
    }

}
