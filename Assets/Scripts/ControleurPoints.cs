using TMPro;
using UnityEngine;

/// <summary>
/// Classe pour gérer l'ensemble des points du joueur
/// Quand le nombre de points change, on change aussi l'affichage
/// Format singleton généré avec l'aide de ChatGPT (le 29 avril 2024)
/// </summary>
public class ControleurPoints : MonoBehaviour
{
    /// <summary>
    /// Instance unique de cette classe
    /// </summary>
    private static ControleurPoints instance;

    /// <summary>
    /// Les points obtenus dans le jeu
    /// </summary>
    private uint points = 0;

    /// <summary>
    /// Accesseur de points, quand les points changent, change aussi le texte
    /// </summary>
    public uint Points {
        get
        { return points; } 
        set
        {
            points = value;
            textePoints.text = "Points : " + points.ToString();
        }
    }

    /// <summary>
    /// Le texte qui affiche les points au joueur
    /// </summary>
    [SerializeField]
    private TextMeshProUGUI textePoints;

    /// <summary>
    /// S'assure qu'il n'y a qu'une seule instance de cette classe
    /// </summary>
    private void Awake()
    {
        // Vérifie s'il y a déjà une instance existante
        if (instance == null)
        {
            // Si non, fait de cette instance le singleton
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // Si oui, détruit cet objet pour éviter les doublons
            Destroy(gameObject);
        }
    }

    /// <summary>
    /// Retourne l'instance du controleur
    /// </summary>
    /// <returns>l'instance du controleur</returns>
    public static ControleurPoints GetInstance()
    {
        return instance;
    }
}