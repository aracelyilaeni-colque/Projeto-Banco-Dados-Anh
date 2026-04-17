using Segundo_App_BancoDados.Models;

namespace Segundo_App_BancoDados.Repository.Contratc
{
    public interface IUsuarioRepository
    {
        // CRUD - Create, Read, Update, Delete

        IEnumerable<Usuario> ObterTodosUsuarios();

        void Cadastrar(Usuario usuario);

        void Atualizar(Usuario usuario);

        Usuario ObterUsuario(int Id);

        void Excluir(int id);


  
    }
}
