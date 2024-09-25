using ControleDeTarefas.Models;

namespace ControleDeTarefas.Services.LivrosService
{
    public interface IDataDengueInterface
    {
        Task<IEnumerable<Pessoa>> GetAllTarefas();
        Task<Pessoa> GetTarefaByName(string titulo); 
        Task<IEnumerable<Pessoa>> CreateTarefa(Pessoa tarefa);
        Task<IEnumerable<Pessoa>> UpdateTarefa(Pessoa tarefa);
        Task<IEnumerable<Pessoa>> DeletionTarefa(string titulo);

    }
}
