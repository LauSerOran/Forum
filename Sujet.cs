using System;

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

    public Boolean ajoutReponseSujet(Reponse reponse)
    {
        Boolean fait = false;
        int longListReponse = listReponse.Length();
        listReponse.Add(reponse);
        if (longListReponse < listReponse.Length())
        {
            fait = true;
        }
        return fait;
    }

}
