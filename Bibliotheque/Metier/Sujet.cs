using System;
using System.Collections.Generic;

public class Sujet
{
    private List<Reponse> listReponse = new List<Reponse>();
    private string auteur;
    private DateTime dateCreationSujet;
    private string titreSujet;
    private string descriptionSujet;
    private string rubrique;

    public Sujet()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Sujet"/> class.
    /// </summary>
    /// <param name="auteur">The auteur.</param>
    /// <param name="titre">The titre.</param>
    /// <param name="description">The description.</param>
    /// <param name="rubrique">The rubrique.</param>
    public Sujet(string auteur, string titre, string description, string rubrique)
    {
        this.auteur = auteur;
        this.titreSujet = titre;
        this.descriptionSujet = description;
        this.rubrique = rubrique;
        this.dateCreationSujet = DateTime.Now;
    }

    /// <summary>
    /// Ajouts the reponse sujet.
    /// </summary>
    /// <param name="reponse">The reponse.</param>
    /// <returns></returns>
    public Boolean ajoutReponseSujet(Reponse reponse)
    {
        Boolean fait = false;
        int longListReponse = listReponse.Count;
        listReponse.Add(reponse);
        if (longListReponse < listReponse.Count)
        {
            fait = true;
        }
        return fait;
    }

    public Boolean suppressionReponseSujet(Reponse reponse)
    {
        Boolean fait = false;
        int longListReponse = listReponse.Count;
        listReponse.Remove(reponse);
        if (longListReponse > listReponse.Count)
        {
            fait = true;
        }
        return fait;
    }

}
