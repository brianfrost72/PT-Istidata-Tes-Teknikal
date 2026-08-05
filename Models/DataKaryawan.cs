using System;
using System.Collections.Generic;

namespace data_karyawan_backend.Models;

public partial class DataKaryawan
{
    public int Id { get; set; }

    public string Nik { get; set; } = null!;

    public string Nama { get; set; } = null!;

    public DateOnly TanggalLahir { get; set; }

    public string JenisKelamin { get; set; } = null!;

    public string Alamat { get; set; } = null!;

    public int? IdNegara { get; set; }

    public DateTime DibuatTgl { get; set; }

    public virtual Negara? IdNegaraNavigation { get; set; }
}
