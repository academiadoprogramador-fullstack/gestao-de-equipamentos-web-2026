using GestaoDeEquipamentosWeb.ConsoleApp.Compartilhado;
using GestaoDeEquipamentosWeb.ConsoleApp.Compartilhado.Arquivos;
using GestaoDeEquipamentosWeb.ConsoleApp.Models;
using GestaoDeEquipamentosWeb.ConsoleApp.ModuloChamado;
using GestaoDeEquipamentosWeb.ConsoleApp.ModuloEquipamento;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

public class ChamadoController : Controller
{
    private readonly IRepositorio<Chamado> repositorioChamado;
    private readonly IRepositorio<Equipamento> repositorioEquipamento;

    public ChamadoController()
    {
        ContextoJson contexto = new ContextoJson();
        contexto.Carregar();

        repositorioChamado = new RepositorioChamadoEmArquivo(contexto);
        repositorioEquipamento = new RepositorioEquipamentoEmArquivo(contexto);
    }

    [HttpGet]
    public ActionResult Listar()
    {
        List<Chamado> chamados = repositorioChamado.SelecionarTodos();

        List<ListarChamadoViewModel> visualizarChamados = new List<ListarChamadoViewModel>();

        foreach (Chamado c in chamados)
        {
            ListarChamadoViewModel listarChamadoVm = new ListarChamadoViewModel(
                c.Id,
                c.Titulo,
                c.Equipamento.Nome,
                c.DataAbertura,
                c.TempoDecorrido,
                c.EstaConcluido
            );

            visualizarChamados.Add(listarChamadoVm);
        }

        return View(visualizarChamados);
    }

    [HttpGet]
    public ActionResult Cadastrar()
    {
        ViewBag.Equipamentos = CarregarEquipamentos();

        CadastrarChamadoViewModel cadastrarVm = new CadastrarChamadoViewModel(string.Empty, null, string.Empty);

        return View(cadastrarVm);
    }

    [HttpPost]
    public ActionResult Cadastrar(CadastrarChamadoViewModel cadastrarVm)
    {
        return View();
    }

    private List<SelectListItem> CarregarEquipamentos()
    {
        List<Equipamento> equipamentos = repositorioEquipamento.SelecionarTodos();

        List<SelectListItem> selecionarEquipamentos = new List<SelectListItem>();

        foreach (Equipamento e in equipamentos)
        {
            SelectListItem selecionarEquipamentoVm = new SelectListItem(
                e.Nome,
                e.Id
            );

            selecionarEquipamentos.Add(selecionarEquipamentoVm);
        }

        return selecionarEquipamentos;
    }
}
