using System.ComponentModel.DataAnnotations;

namespace ThuHoach.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}