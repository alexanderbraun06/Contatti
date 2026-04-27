namespace RubricaCompleta.Data
{
    public class Contatto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string NumeroTelefono { get; set; }
        public string? NumeroTelefonoAziendale { get; set; }
        public string Email { get; set; }
        public string IndirizzoPEC { get; set; }
        public string Professione { get; set; }
        public string Azienda { get; set; }
        public DateOnly DataAssunzione {  get; set; }
        public Utente Utente { get; set; }
        
    }
}
