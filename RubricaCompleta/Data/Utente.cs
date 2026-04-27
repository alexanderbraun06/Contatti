using RubricaCompleta.Data;

public class Utente
{
    public int UserId { get; set; }
    public string Username { get; set; }
    public string PasswordHash { get; set; }

    public List<Contatto> Contatti { get; set; }
}
