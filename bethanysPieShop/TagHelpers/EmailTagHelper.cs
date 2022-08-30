using Microsoft.AspNetCore.Razor.TagHelpers;

namespace bethanysPieShop.TagHelpers
{
    public class EmailTagHelper : TagHelper //<email olarak erisilebilir oldu
    {
        public string? Address { get; set; }
        public string? Content { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            output.Attributes.SetAttribute("href", "mailto:" + Address);
            output.Content.SetContent(Content);
        }
    }
}
