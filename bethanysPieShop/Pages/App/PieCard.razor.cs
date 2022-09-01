using bethanysPieShop.Models;
using Microsoft.AspNetCore.Components;

namespace bethanysPieShop.Pages.App
{
    public partial class PieCard
    {
        [Parameter]
        public Pie? Pie { get; set; }
    }
}
