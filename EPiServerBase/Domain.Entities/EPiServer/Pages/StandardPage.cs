using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace Domain.Entities.EPiServer.Pages
{
    [ContentType(
        DisplayName = "StandardPage",
        GUID = "1d1eb7b5-6f17-4790-90f8-4b1cad937ab4",
        Description = "")]
    public class StandardPage : PageData
    {
        [CultureSpecific]
        [Display(
            Name = "Main intro",
            Description = "",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual string MainIntro { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description =
                "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual XhtmlString MainBody { get; set; }
    }
}