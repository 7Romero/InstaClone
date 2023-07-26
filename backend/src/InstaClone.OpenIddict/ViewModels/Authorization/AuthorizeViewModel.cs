using System.ComponentModel.DataAnnotations;

namespace InstaClone.OpenIddict.ViewModels.Authorization;

public class AuthorizeViewModel
{
    [Display(Name = "Application")]
    public string ApplicationName { get; set; }

    [Display(Name = "Scope")]
    public string Scope { get; set; }
}
