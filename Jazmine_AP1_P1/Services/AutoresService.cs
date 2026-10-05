
using Microsoft.EntityFrameworkCore;
using Jazmine_AP1_P1.Context;
using Jazmine_AP1_P1.Models;
using System.Linq.Expressions;

namespace Jazmine_AP1_P1.Services;

public class AutoresService(
    IDbContextFactory<Contexto> contextFactory
) : Aplicada1.Core.IService<Autores, int>
{
    public async Task<bool> Guardar(Autores autor)
    {
        if (!await Existe(autor.IdAutor))
        {
            return await Insertar(autor);
        }
        else
        {
            return await Modificar(autor);
        }
    }

    private async Task<bool> Existe(int idAutor)
    {
        await using var contexto = await contextFactory.CreateDbContextAsync();
        return await contexto.Autores.AnyAsync(a => a.IdAutor == idAutor);
    }

    private async Task<bool> Insertar(Autores autor)
    {
        await using var contexto = await contextFactory.CreateDbContextAsync();
        contexto.Autores.Add(autor);
        return await contexto.SaveChangesAsync() > 0;
    }

    private async Task<bool> Modificar(Autores autor)
    {
        await using var contexto = await contextFactory.CreateDbContextAsync();
        contexto.Update(autor);
        return await contexto.SaveChangesAsync() > 0;
    }

    public async Task<Autores?> Buscar(int idAutor)
    {
        await using var contexto = await contextFactory.CreateDbContextAsync();
        return await contexto.Autores.FirstOrDefaultAsync(a => a.IdAutor == idAutor);
    }

    public async Task<bool> Eliminar(int idAutor)
    {
        await using var contexto = await contextFactory.CreateDbContextAsync();
        return await contexto.Autores
            .Where(a => a.IdAutor == idAutor)
            .ExecuteDeleteAsync() > 0;
    }

    public async Task<List<Autores>> GetList(Expression<Func<Autores, bool>> criterio)
    {
        await using var contexto = await contextFactory.CreateDbContextAsync();
        return await contexto.Autores
            .Where(criterio)
            .AsNoTracking()
            .ToListAsync();
    }
}
