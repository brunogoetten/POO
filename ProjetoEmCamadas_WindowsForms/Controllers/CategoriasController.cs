using ProjetoEmCamadas_WindowsForms.DAL;
using System.Linq;

namespace ProjetoEmCamadas_WindowsForms.Controllers
{
    class CategoriasController
    {
        LojaDBContainer contexto = new LojaDBContainer();

        public void Adicionar(Categoria categoria)
        {
            contexto.Categorias.Add(categoria);
            contexto.SaveChanges();
        }

        public List<Categoria>Listar()
        {
            contexto.Categorias.ToList();
        }
    }
}
