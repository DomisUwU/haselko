using haselko.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace haselko.Pages
{
    public class HasloModel : PageModel
    {
        [BindProperty]
        public Haslo MojeHaslo { get; set; }

        public HasloModel()
        {
            if (MojeHaslo == null)
            {
                MojeHaslo = new Haslo();
            }
            MojeHaslo.Znaki = new List<Dodatki>
            {
                new Dodatki{Typ = "Cyfry"},
                new Dodatki{Typ = "Duze litery"},
                new Dodatki{Typ = "Znaki specjalne"},

            };
        }
        public void OnGet()
        {
        }

        public void OnPost()
        {
            ViewData["post"] = true;
            if (ModelState.IsValid)
            {
                var result = MojeHaslo;
            }
            else
            {

            }
        }
    }
}
