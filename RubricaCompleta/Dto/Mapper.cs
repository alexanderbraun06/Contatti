using RubricaCompleta.Data;
using RubricaCompleta.Dto;
public class Mapper
{
    public ContattoDto MapBaseEntityToDto(Contatto entity)
    {
        ContattoDto dto = new ContattoDto()
        {
            Nome = entity.Nome,
            Cognome = entity.Cognome,
            NumeroTelefonoAziendale = entity.NumeroTelefonoAziendale,
            Email = entity.Email,
            IndirizzoPEC = entity.IndirizzoPEC,
            Professione = entity.Professione,
        };
        return dto;
    }

    public Contatto MapDtoToEntity(ContattoDto dto)
    {
        Contatto entity = new Contatto()
        {
            Nome = dto.Nome,
            Cognome = dto.Cognome,
            NumeroTelefonoAziendale = dto.NumeroTelefonoAziendale,
            Email = dto.Email,
            IndirizzoPEC = dto.IndirizzoPEC,
            Professione = dto.Professione,
        };
        return entity;
    }
    public UtenteDto MapBaseEntityToDto(Utente entity)
    {
        UtenteDto dto = new UtenteDto()
        {
            UserId = entity.UserId,
            Username = entity.Username,
            PasswordHash = entity.PasswordHash,

        };
        return dto;
    }

    public Utente MapDtoToEntity(Utente dto)
    {
        Utente entity = new Utente()
        {
            UserId = dto.UserId,
            Username = dto.Username,
            PasswordHash = dto.PasswordHash,
        };
        return entity;
    }
}