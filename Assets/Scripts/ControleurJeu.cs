using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Controleur de jeu qui recommnce leu jeu si un certain bouton est appuyé
/// </summary>
public class ControleurJeu : MonoBehaviour
{
    /// <summary>
    /// recommnce leu jeu si un certain bouton est appuyé
    /// </summary>
    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            // Solution trouvé ici : https://stackoverflow.com/questions/65851443/how-do-i-restart-the-scene-that-im-currently-in-through-script-in-unity-2d-so
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
