using ControleDeTarefas.Models;
using ControleDeTarefas.Services.LivrosService;
using Microsoft.AspNetCore.Mvc;

namespace ControleDeTarefas.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataDengueController : ControllerBase
    {
        private readonly IDataDengueInterface _controleDeTarefasInterface;
        public DataDengueController(IDataDengueInterface TarefaInterface)
        {
            _controleDeTarefasInterface = TarefaInterface;
        }

        [HttpGet]


        [HttpPost("Pessoa")]
        public async Task<ActionResult<IEnumerable<Pessoa>>> CreateTarefa(Pessoa tarefaId)
        {
            IEnumerable<Pessoa> tarefa = await _controleDeTarefasInterface.CreateTarefa(tarefaId);

            return Ok(tarefa);
        }
        public async Task<ActionResult<IEnumerable<Pessoa>>> GetAllTarefas()
        {
            IEnumerable<Pessoa> tarefa = await _controleDeTarefasInterface.GetAllTarefas();

            if (!tarefa.Any())
            {
                return NotFound("Nenhum registro localizado");
            }

            return Ok(tarefa);
        }
        
        [HttpGet("Titulo")]
        public async Task<ActionResult<Pessoa>> GetTarefaByName(string titulo)
        {
            Pessoa tarefa = await _controleDeTarefasInterface.GetTarefaByName(titulo);

            if (tarefa == null)
            {
                return NotFound("Tarefa nao encontrado");
            }
            return Ok(tarefa);
        }

        [HttpPost("Tarefa")]
        public async Task<ActionResult<IEnumerable<Pessoa>>> CreateTarefa(Pessoa tarefaId)
        {
            IEnumerable<Pessoa> tarefa = await _controleDeTarefasInterface.CreateTarefa(tarefaId);

            return Ok(tarefa);
        }
        
        [HttpPut]
        public async Task<ActionResult<IEnumerable<Pessoa>>> UpdateTarefa(Pessoa tarefa)
        {
            Pessoa Titulo = await _controleDeTarefasInterface.GetTarefaByName(tarefa.Titulo);

            if (Titulo.Titulo == null)
                return NotFound("Titulo não encontrado");

            IEnumerable<Pessoa> tarefas = await _controleDeTarefasInterface.UpdateTarefa(tarefa);

            return Ok(tarefas);
        }
        [HttpDelete("Tarefa")]
        public async Task<ActionResult<IEnumerable<Pessoa>>> DeletionTarefa(string titulo)
        {
            Pessoa registro = await _controleDeTarefasInterface.GetTarefaByName(titulo);

            if (registro.Titulo == null)
                return NotFound("Tarefa não encontrado");

            IEnumerable<Pessoa> tarefas = await _controleDeTarefasInterface.DeletionTarefa(titulo);

            return Ok(tarefas);
        }
    }

}
