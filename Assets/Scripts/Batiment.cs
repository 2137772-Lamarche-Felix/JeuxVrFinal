using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

/// <summary>
/// Classe pour les différents batiments
/// Détecte les collisions de ces deniers et ajoute des points en conséquence
/// </summary>
public class Batiment : MonoBehaviour
{
    /// <summary>
    /// Le controleur de points
    /// </summary>
    private ControleurPoints controleurPoints;

    /// <summary>
    /// Va chercher l'instance du controleur de points lors du démarrage
    /// </summary>
    private void Start()
    {
        controleurPoints = ControleurPoints.GetInstance();
    }

    /// <summary>
    /// Désactive le XR Grab Interactable pour que le batiment ne puisse plus être déplacé par le joueur
    /// </summary>
    private void Desactiver() 
    {
        GetComponent<XRGrabInteractable>().enabled = false;
    }

    /// <summary>
    /// Détecte les collisions
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
