using Desafio_Rhitmo.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Desafio_Rhitmo.Repository.Interfaces
{
    public interface ICadastroCartaoRepository
    {
        Task<IEnumerable<CadastroCartaoDto>> FindAll();

        Task<CadastroCartaoDto> FindById(long id);

        Task<CadastroCartaoDto> Create(CadastroCartaoDto cadastrocartaodto);

        Task<CadastroCartaoDto> Update(CadastroCartaoDto cadastrocartao);

        Task<bool> Delete(long id);
    }
}
