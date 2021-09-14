using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Webshop_backend.Db;
using static Webshop_backend.Db.Klase;

namespace Webshop_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProizvodController : ControllerBase
    {
        private readonly MyDbContext context;
        private readonly IWebHostEnvironment webHostEnvironment;

        public ProizvodController(MyDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            this.context = context;
            this.webHostEnvironment = webHostEnvironment;
        }
        //javlja se na api/proizvod
        [HttpGet("")]
        [Authorize]
        public List<Proizvod> GetProizvodi()
        {
            return context.proizvodi.ToList();
        }
        //api/proizvod/search?cijenaOd=1000&cijenaDo=500&text=Alt
        [HttpGet("search")]
        public List<Proizvod> Search(decimal? cijenaOd = null, decimal? cijenaDo = null, string text = null)
        {

            return context.proizvodi.Where
                (p =>
                (p.ProdajnaCijena >= cijenaOd || cijenaOd == null) &&
                (p.ProdajnaCijena <= cijenaDo || cijenaDo == null) &&
                (p.Naziv.Contains(text) || p.Broj.Contains(text) || text == null)).ToList();





        }

        [HttpGet("{id}")]
        public Proizvod GetById(int id)
        {
            return context.proizvodi.FirstOrDefault(p => p.IdProizvod==id);
        }


        [HttpPost("")]
        public Proizvod Create(Proizvod proizvod)
        {
            context.proizvodi.Add(proizvod);
            
            context.SaveChanges();
            return proizvod;

        }

        [HttpPut("")]
        public Proizvod Update(Proizvod proizvod)
        {
            context.proizvodi.Update(proizvod);
            
            context.SaveChanges();
            return proizvod;
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            context.Database.ExecuteSqlInterpolated($"DELETE FROM Proizvod WHERE idProizvod={id}");
        }
    }
}
