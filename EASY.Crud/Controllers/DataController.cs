using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using Abp.AutoMapper;
using EASY.Crud.Entity;
using EASY.Crud.Entity.Model;
using EASY.Crud.Entity.ViewModel;

namespace EASY.Crud.Controllers
{
    [RoutePrefix("api/data")]
    public class DataController : ApiController
    {
        [Route("GetKnowledgeBase")]
        public async Task<IHttpActionResult> GetKnowledgeBase()
        {
            try
            {
                using (var context = new Context())
                {
                    var ret = await context.KnowledgeBase.ToListAsync();
                    return Ok(ret);
                }
            }
            catch(Exception ex)
            {
            }

            return BadRequest("Erro ao consultar dados");
        }

        [Route("GetForms")]
        public async Task<IHttpActionResult> GetForms()
        {
            try
            {
                using (var context = new Context())
                {
                    var ret = await context.Person.Where(x => !x.IsDeleted).ToListAsync();
                    var r = ret.MapTo<List<VmPerson>>();
                    return Ok(r);
                }
            }
            catch(Exception ex)
            {
            }

            return BadRequest("Erro ao consultar dados");
        }

        [Route("PostPerson")]
        [HttpPost]
        public async Task<IHttpActionResult> PostPerson(Person person)
        {
            try
            {
                using (var context = new Context())
                {
                    context.Person.AddOrUpdate(person);
                    context.BankInfo.AddOrUpdate(person.BankInfo);
                    foreach (var knowledge in person.Knowledges) { context.Knowledge.AddOrUpdate(knowledge); }

                    await context.SaveChangesAsync();
                    return Ok("Dados enviados com sucesso!");
                }
            }
            catch
            {
            }

            return BadRequest("Erro ao cadastrar dados");
        }

        [Route("DeletePerson")]
        [HttpDelete]
        public async Task<IHttpActionResult> DeletePerson(Guid id)
        {
            try
            {
                using (var context = new Context())
                {
                    var person = context.Person.FirstOrDefault(x => x.Id == id);

                    person.IsDeleted = true;
                    person.BankInfo.IsDeleted = true;

                    await context.SaveChangesAsync();
                    return Ok("Dados deletados com sucesso!");
                }
            }
            catch
            {
            }

            return BadRequest("Erro ao deletar dados");
        }
    }
}