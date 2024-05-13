using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

/// <summary>
/// Classe pour les diff�rents batiments
/// D�tecte les collisions de ces deniers et ajoute des points en cons�quence
/// </summary>
public class Batiment : MonoBehaviour
{
    /// <summary>
    /// Le controleur de points
    /// </summary>
    private ControleurPoints controleurPoints;

    /// <summary>
    /// Va chercher l'instance du controleur de points lors du d�marrage
    /// </summary>
    private void Start()
    {
        controleurPoints = ControleurPoints.GetInstance();
    }

    /// <summary>
    /// D�sactive le XR Grab Interactable pour que le batiment ne puisse plus �tre d�plac� par le joueur
    /// </summary>
    private void Desactiver() 
    {
        GetComponent<XRGrabInteractable>().enabled = false;
    }

    /// <summary>
    /// D�tecte les collisions
    /// </summary>
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Batiment>() != null)
        {
            controleurPoints.Points += 10;
        }
        else if(collision.gameObject.GetComponent<Plancher>() != null)
        {
            Desactiver();
            controleurPoints.Points += 100;
        }
    }
}
