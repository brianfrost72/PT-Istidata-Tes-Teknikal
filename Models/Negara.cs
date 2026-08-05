using System;
using System.Collections.Generic;

namespace data_karyawan_backend.Models;

public partial class Negara
{
    public int Id { get; set; }

    public string Negara1 { get; set; } = null!;

    public DateTime DibuatTgl { get; set; }

    public virtual ICollection<DataKaryawan> DataKaryawans { get; set; } = new List<DataKaryawan>();
}
