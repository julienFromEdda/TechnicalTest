namespace UserApi.Models.Request;

/// <summary>
/// Requête client afin de rechercher des utilisateurs
/// </summary>
public class UserRequest
{
    /// <summary>
    /// Permet de rechercher sur base d'un terme
    /// </summary>
    public string? Term { get; set; }
}
