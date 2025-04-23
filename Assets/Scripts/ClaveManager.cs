using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClaveManager : MonoBehaviour
{
    public TMP_InputField inputClave;
    public TextMeshProUGUI txtMansage;

    string clave = "tequierogero";
    // Start is called before the first frame update
    void Start()
    {
        txtMansage.text = string.Empty;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ComprobarClave()
    {
        string claveIngresada = inputClave.text;
        if (claveIngresada!=clave)
        {
            txtMansage.text = "Acceso denegado";
            inputClave.text = "";
        }
        else
        {
            txtMansage.text = "Bienvenido";
        }
    }
}
