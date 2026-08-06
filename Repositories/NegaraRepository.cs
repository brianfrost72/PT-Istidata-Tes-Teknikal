using data_karyawan_backend.Data;
using data_karyawan_backend.Models;

namespace data_karyawan_backend.Repositories;

public class NegaraRepository : INegaraRepository
{
    private readonly AppDbContext _context;

    public NegaraRepository(AppDbContext context)
    {
        _context = context;
    }

    public List<Negara> GetAll()
    {
        return _context.Negaras
            .OrderBy(x => x.Negara1)
            .ToList();
    }
}