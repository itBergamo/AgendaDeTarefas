namespace AgendaDeTarefas.Models
{
    public class Tarefa
    { 
    public int Tarefa_id { get; set; }
    public string Titulo { get; set; }
    public string Descricao { get; set; }
    public DateOnly DataTarefa { get; set; }
    public TimeOnly Inicio { get; set; }
    public TimeOnly Fim { get; set; }
    public string Prioridade { get; set; }
    public Boolean finalizada { get; set; }
    }
}
