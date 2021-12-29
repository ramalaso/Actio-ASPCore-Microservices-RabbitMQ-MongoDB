namespace Actio.Common.Commands
{
   public class Authenticauser : ICommand
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}