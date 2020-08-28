using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Firebase;
using Firebase.Database;
using Firebase.Unity.Editor;
using System;
public class LoadData : MonoBehaviour
{
    public string Accion;
    public string A;


    void Start()
    {

        // Set up the Editor before calling into the realtime database.
        FirebaseApp.DefaultInstance.SetEditorDatabaseUrl("https://panecillo-fb589.firebaseio.com/");

        // Get the root reference location of the database.
        DatabaseReference reference = FirebaseDatabase.DefaultInstance.RootReference;
    }

    void Update()
    {
        FirebaseDatabase.DefaultInstance.GetReference("Botones").Child("Accion").GetValueAsync().ContinueWith(task => {
            if (task.IsFaulted)
            {
                // Handle the error...
            }
            else if (task.IsCompleted)
            {
                DataSnapshot snapshot = task.Result;
                A = snapshot.Value.ToString();
                if (A == "A")
                {
                    Accion = "Encender luz techo";
                }
                else if (A == "B")
                {
                    Accion = "Encender luz pasillo";
                }
                else if (A == "C")
                {
                    Accion = "Encender luz cuadros";
                }
                else if (A == "D")
                {
                    Accion = "Encender luz locales";
                }
                else if (A == "E")
                {
                    Accion = "Encender luz techo1";
   
                }
                else if (A == "F")
                {
                    Accion = "Encender luz pasillo cristal";
                }
                else if (A == "G")
                {
                    Accion = "Encender luz vitrinas";
                }
                else if (A == "H")
                {
                    Accion = "Encender luz techo 2";
                }
                else if (A == "I")
                {
                    Accion = "Encender luz cuadros 2";
                }
                else if (A == "J")
                {
                    Accion = "Encender luz techo 3";
                }
                else if (A == "K")
                {
                    Accion = "Encender luz cuadros 3";
                }
                else if (A == "L")
                {
                    Accion = "Encender luz apliques";
                }
                else if (A == "M")
                {
                    Accion = "Encender luz reflectores";
                }
                else if (A == "N")
                {
                    Accion = "Apagar luz techo";
                }
                else if (A == "Ñ")
                {
                    Accion = "Apagar luz pasillo";
                }
                else if (A == "O")
                {
                    Accion = "Apagar luz cuadros";
                }
                else if (A == "P")
                {
                    Accion = "Apagar luz locales";
                }
                else if (A == "Q")
                {
                    Accion = "Apagar luz techo1";

                }
                else if (A == "R")
                {
                    Accion = "Apagar luz pasillo cristal";
                }
                else if (A == "S")
                {
                    Accion = "Apagar luz vitrinas";
                }
                else if (A == "T")
                {
                    Accion = "Apagar luz techo 2";
                }
                else if (A == "U")
                {
                    Accion = "Apagar luz cuadros 2";
                }
                else if (A == "V")
                {
                    Accion = "Apagar luz techo 3";
                }
                else if (A == "W")
                {
                    Accion = "Apagar luz cuadros 3";
                }
                else if (A == "X")
                {
                    Accion = "Apagar luz apliques";
                }
                else if (A == "Y")
                {
                    Accion = "Apagar luz reflectores";
                }

            }
        });
    }
}
