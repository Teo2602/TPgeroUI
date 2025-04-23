using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClaveManager : MonoBehaviour
{
    public TMP_InputField inputClave;
    public TMP_InputField inputUser;
    public TextMeshProUGUI txtMansage;

    string clave = "tequierogero";
    string user = "Teo";
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
        string userIngresado = inputUser.text;
        if (claveIngresada!=clave||userIngresado!=user)
        {
            txtMansage.text = "Acceso denegado";
            inputClave.text = "";
            inputUser.text = "";
        }
        else
        {
            txtMansage.text = "Bienvenido";
        }
    }
}
