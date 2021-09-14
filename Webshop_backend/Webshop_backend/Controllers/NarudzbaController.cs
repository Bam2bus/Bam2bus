using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Webshop_backend.Db;
using static Webshop_backend.Db.Klase;

namespace Webshop_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NarudzbaController : ControllerBase
    {
        private readonly MyDbContext context;

        public NarudzbaController(MyDbContext context)
        {
            this.context = context;
        }
        //api/narudzba/id
        [HttpGet("{id}")]
        public Narudzba GetById(int id)
        {
            return context.narudzbe.Include(n=>n.Detalji).ThenInclude(d=>d.Proizvod).Include(n=>n.Klijent).ThenInclude(k=>k.IdOsoba).FirstOrDefault(n => n.IdNarudzba == id); //include kada želimo prikazati još nešto uz neku tablicu
        } //Ako nije direktno spojen sa tablicom ide ThenInclude
       
    }
}
