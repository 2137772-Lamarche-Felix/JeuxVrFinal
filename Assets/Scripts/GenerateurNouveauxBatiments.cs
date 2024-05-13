using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Script pour énérer de nouveaux batiments
/// </summary>
public class GenerateurNouveauxBatiments : MonoBehaviour
{
    /// <summary>
    /// La position minimum en X ou on peut faire apparaitre un batiment
    /// </summary>
    [SerializeField]
    private float posminX;

    /// <summary>
    /// La position minimum en X ou on peut faire apparaitre un batiment
    /// </summary>
    [SerializeField]
    private float posmaxX;

    /// <summary>
    /// La position minimum en X ou on peut faire apparaitre un batiment
    /// </summary>
    [SerializeField]
    private float posminZ;

    /// <summary>
    /// La position minimum en X ou on peut faire apparaitre un batiment
    /// </summary>
    [SerializeField]
    private float posmaxZ;

    /// <summary>
    /// La position minimum en X ou on peut faire apparaitre un batiment
    /// </summary>
    [SerializeField]
    private float posY;

    /// <summary>
    /// Les batiments pouvant être générés
    /// </summary>
    [SerializeField]
    private GameObject[] batiments;

    /// <summary>
    /// Retourne un batiment au hasard dans le tableau de batiments
    /// </summary>
    /// <returns>un batiment au hasard</returns>
    private GameObject ChoisiBatiment()
    {
        return batiments[Random.Range(0, batiments.Length)];
    }

    /// <summary>
    /// Trouve une position au hasard dans l'espace déterminé
    /// </summary>
    /// <returns>une position au hasard</returns>
    private Vector3 ChoisiPoisition()
    {
        return new Vector3(
            Random.Range(posminX, posmaxX),
            posY,
            Random.Range(posminZ, posmaxZ)
            );
    }

    /// <summary>
    /// Trouve une orientation au hasard
    /// Aide de ChatGPT (29 Avril 2024)
    /// </summary>
    /// <returns>une orientation au hasard</returns>
    private Quaternion ChoisiRotation()
    {
        return Quaternion.Euler(0, Random.Range(0f, 360f), 0);
    }

    /// <summary>
    /// Génère un nouveau batiment
    /// </summary>
    private void GenereBatiment()
    {
        GameObject batiment = Instantiate(ChoisiBatiment());
        batiment.GetComponent<Rigidbody>().position = ChoisiPoisition();
        batiment.GetComponent<Rigidbody>().rotation = ChoisiRotation();
    }

    /// <summary>
    /// Si le joueur appuie sur le bouton "A", génère un batiment
    /// </summary>
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GenereBatiment();
        }
    }
}
