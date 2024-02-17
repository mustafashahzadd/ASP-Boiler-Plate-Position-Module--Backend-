using System.ComponentModel.DataAnnotations;

namespace MyOrganization.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}