using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarteiraDeAcoes.Data;
using CarteiraDeAcoes.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;



namespace CarteiraDeAcoes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AcaoController : ControllerBase
    {
        private DataContext dataContext;

        public AcaoController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        [HttpGet]
        public ActionResult<List<Acao>> Historico()
        {
            return dataContext.Acoes.ToList();
        }


        [HttpPost("cadastrar")]
        public ActionResult<Acao> Cadastrar([FromBody] Acao acao)
        {
            acao.Id = Guid.NewGuid();

            dataContext.Acoes.Add(acao);

            dataContext.SaveChanges();

            return acao;
        }

        [HttpGet("listar/{id}")]
        public ActionResult<Acao> Listar(Guid id)
        {
            return dataContext.Acoes.Where(acaoTemp => acaoTemp.Id == id).FirstOrDefault();
        }

        [HttpDelete("{id}")]
        public ActionResult<Guid> Excluir(Guid id)
        {
            Acao acao = dataContext.Acoes.Where(acaoTemp => acaoTemp.Id == id).FirstOrDefault();
            if (acao != null)
            {
                dataContext.Acoes.Remove(acao);
                dataContext.SaveChanges();
            }
            return id;
        }

        [HttpPut("editar")]
        public ActionResult<Guid> Editar([FromBody] Acao acaoEdit)
        {
            Acao acao = dataContext.Acoes.Where(acaoTemp => acaoTemp.Id == acaoEdit.Id).FirstOrDefault();
            if(acao != null)
            {
                acao.Codigo = acaoEdit.Codigo;
                dataContext.Acoes.Update(acao);
                dataContext.SaveChanges();
            }
            return acao.Id;
        } 
    }
}