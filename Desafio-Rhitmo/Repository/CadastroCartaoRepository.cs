using AutoMapper;
using Desafio_Rhitmo.Dto;
using Desafio_Rhitmo.Model;
using Desafio_Rhitmo.Repository.Interfaces;
using GeekShopping.CartApi.Model.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_Rhitmo.Repository
{
    public class CadastroCartaoRepository : ICadastroCartaoRepository
    {

        private readonly MySQLContext _context;
        private IMapper _mapper;

        public CadastroCartaoRepository(MySQLContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<CadastroCartaoDto> Create(CadastroCartaoDto cadastrocartaoDto)
        {
            CadastroCartao cadastrocartaos = _mapper.Map<CadastroCartao>(cadastrocartaoDto);
            _context.CadastroCartaos.Add(cadastrocartaos);
            await _context.SaveChangesAsync();
            return _mapper.Map<CadastroCartaoDto>(cadastrocartaos);
        }

        public async Task<IEnumerable<CadastroCartaoDto>> FindAll()
        {
            List<CadastroCartao> cadastros = await _context.CadastroCartaos.ToListAsync();
            return _mapper.Map<List<CadastroCartaoDto>>(cadastros);
        }

        public async Task<CadastroCartaoDto> FindById(long id)
        {
            CadastroCartao cadastros = await _context.CadastroCartaos.Where(p => p.Id == id)
                .FirstOrDefaultAsync() ?? new CadastroCartao();
            return _mapper.Map<CadastroCartaoDto>(cadastros);
        }

        public async Task<CadastroCartaoDto> Update(CadastroCartaoDto cadastrocartaodto)
        {
            CadastroCartao Cadastros = _mapper.Map<CadastroCartao>(cadastrocartaodto);
            _context.CadastroCartaos.Add(Cadastros);
            await _context.SaveChangesAsync();
            return _mapper.Map<CadastroCartaoDto>(Cadastros);
        }

        public async Task<bool> Delete(long id)
        {
            try
            {
                CadastroCartao cadastro = await _context.CadastroCartaos.Where(p => p.Id == id)
                    .FirstOrDefaultAsync() ?? new CadastroCartao();
                if (cadastro.Id <= 0) return false;
                _context.CadastroCartaos.Remove(cadastro);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
