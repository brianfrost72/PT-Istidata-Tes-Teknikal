using data_karyawan_backend.Models;

namespace data_karyawan_backend.Repositories;

public interface IDataKaryawanRepository
{
    List<DataKaryawan> GetAll();

    DataKaryawan? GetById(int id);

    void Add(DataKaryawan data);

    void Update(DataKaryawan data);

    void Delete(int id);
}