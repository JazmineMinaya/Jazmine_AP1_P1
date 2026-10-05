
using Microsoft.EntityFrameworkCore;
using Jazmine_AP1_P1.Context;
using Jazmine_AP1_P1.Models;
using System.Linq.Expressions;

namespace Jazmine_AP1_P1.Services;

public class ModelsService(
    IDbContextFactory<Contexto> contextFactory
) : Aplicada1.Core.IService<Model, int>
{
    public async Task<bool> Guardar(Model model)
    {
        throw new NotImplementedException();
    }
    private async Task<bool> Existe(int modelId)
    {
        throw new NotImplementedException();
    }

    private async Task<bool> Insertar(Model mode1)
    {
        throw new NotImplementedException();
    }

    private async Task<bool> Modificar(Model model)
    {
        throw new NotImplementedException();
    }

    public async Task<Model?> Buscar(int modelId)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> Eliminar(int modelId)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Model>> GetList(Expression<Func<Model, bool>> criterio)
    {
        throw new NotImplementedException();
    }
}
