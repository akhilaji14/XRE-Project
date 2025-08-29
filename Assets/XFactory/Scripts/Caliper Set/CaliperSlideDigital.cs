using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CaliperSlideDigital : MonoBehaviour
{
    [SerializeField] private float xLimit = 0.148f; // Local space offset of the slide stopper on the model
    private float displayMultiplier = 1216.2f; // Eyeballed corrective value due to gauge imprecision for milimeters
    [SerializeField] private TextMeshProUGUI displayCanvas;

    void Update()
    {
        float clampedX = Mathf.Clamp(transform.localPosition.x, 0f, xLimit);
        transform.localPosition = new Vector3(clampedX, transform.localPosition.y, transform.localPosition.z);
        displayCanvas.text = (transform.localPosition.x * displayMultiplier).ToString("F2");
    }

}
