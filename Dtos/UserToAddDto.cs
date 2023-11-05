namespace DotnetAPI.Dtos
{
  // Dto -> Data Transfer Object
  public partial class UserToAddDto
  {
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public string Email { get; set; } = "";
    public string Gender { get; set; } = "";
    public bool Active { get; set; }
  }
}
