using System.ComponentModel.DataAnnotations;

namespace ElectricitytDemo.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}