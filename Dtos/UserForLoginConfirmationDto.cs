namespace DotnetAPI.Dtos
{
  public partial class UserForLoginConfirmationDto
  {
    public byte[] PasswordHash {get; set;} = Array.Empty<byte>();
    public byte[] PasswordSalt {get; set;} = Array.Empty<byte>();
  }
}
