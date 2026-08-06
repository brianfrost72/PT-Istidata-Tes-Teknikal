using data_karyawan_backend.Data;
using data_karyawan_backend.Models;
using Microsoft.EntityFrameworkCore;

namespace data_karyawan_backend.Repositories;

public class DataKaryawanRepository : IDataKaryawanRepository
{
    private readonly AppDbContext _context;

    public DataKaryawanRepository(AppDbContext context)
    {
        _context = context;
    }

    public List<DataKaryawan> GetAll()
    {
        return _context.DataKaryawans
            .OrderByDescending(x => x.Id)
            .ToList();
    }

    public DataKaryawan? GetById(int id)
    {
        return _context.DataKaryawans
            .FirstOrDefault(x => x.Id == id);
    }

    public void Add(DataKaryawan data)
    {
        _context.DataKaryawans.Add(data);
        _context.SaveChanges();
    }

    public void Update(DataKaryawan data)
    {
        _context.DataKaryawans.Update(data);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var data = GetById(id);

        if (data != null)
        {
            _context.DataKaryawans.Remove(data);
            _context.SaveChanges();
        }
    }
}