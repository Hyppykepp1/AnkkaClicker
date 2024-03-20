using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ankka : MonoBehaviour
{
    public static int DuckCount;
    public GameObject DuckCountText;

    private TextMeshProUGUI duckCountTextMesh;

    private void Start()
    {
        duckCountTextMesh = DuckCountText.GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        if (duckCountTextMesh != null)
        {
            duckCountTextMesh.text = "" + DuckCount;
        }
    }

    public void WhenClicked()
    {
        DuckCount += 1;
    }
}

