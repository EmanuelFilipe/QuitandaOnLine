using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreWebApp.Data;
using AspNetCoreWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetCoreWebApp.Pages.ClienteCRUD
{
    public class IncluirModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        //Vinculada aos campos do formulario desta pagina
        [BindProperty]
        public Cliente Cliente { get; set; }

        public IncluirModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var cliente = new Cliente();
            if(await TryUpdateModelAsync<Cliente>(cliente, "cliente", 
                obj => obj.Nome, obj => obj.DataNascimento, obj => obj.CPF, obj => obj.Email))
            {
                _context.Clientes.Add(cliente);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Listar");
            }
            return Page();
        }
        
    }
}
