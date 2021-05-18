namespace SubmittingWithoutButtons.Shared
{
    using System.ComponentModel.DataAnnotations;

    public class ExampleModel
    {
        [Required]
        [MinLength(5)]
        public string Message { get; set; }
    }
}