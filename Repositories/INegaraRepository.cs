using data_karyawan_backend.Models;

namespace data_karyawan_backend.Repositories;

public interface INegaraRepository
{
    List<Negara> GetAll();
}