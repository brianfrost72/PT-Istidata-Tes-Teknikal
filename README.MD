# 📋 Data Karyawan Web Application

A web-based employee management application built with **ASP.NET Core MVC (.NET 9)** using the **MVC Architecture**, **Entity Framework Core**, and **MySQL (MariaDB)**.

The application provides CRUD (Create, Read, Update, Delete) functionality for employee data with a modern responsive interface powered by Bootstrap 5 and DataTables.

---

# 📌 Features

- Employee Management
- Add Employee
- Edit Employee
- Delete Employee
- Employee Detail
- Search Employee
- Pagination
- Show Entries
- Responsive Design
- Bootstrap Modal
- MySQL Database
- Entity Framework Core
- Repository Pattern

---

# 🛠️ Technology Stack

| Technology | Version |
|------------|---------|
| ASP.NET Core MVC | .NET 9 |
| Entity Framework Core | 9.x |
| MySQL / MariaDB | 10.x |
| Bootstrap | 5.3 |
| jQuery | 3.7 |
| DataTables | 2.x |
| Font Awesome | 6.x |

---

# 📂 Project Structure

```
DataKaryawanBackend
│
├── Controllers
│     HomeController.cs
│
├── Data
│     AppDbContext.cs
│
├── Models
│     DataKaryawan.cs
│     Negara.cs
│
├── Repositories
│     IDataKaryawanRepository.cs
│     DataKaryawanRepository.cs
│     INegaraRepository.cs
│     NegaraRepository.cs
│
├── Views
│     Home
│        Index.cshtml
│        _Search.cshtml
│        _Table.cshtml
│        _ModalTambah.cshtml
│        _ModalEdit.cshtml
│        _ModalDetail.cshtml
│        _ModalHapus.cshtml
│
├── wwwroot
│     css
│     js
│     images
│
├── appsettings.json
├── Program.cs
└── README.md
```

---

# 🗄️ Database

Database Engine

```
MySQL / MariaDB
```

Database Name

```
pt_istidata_brian
```

Main Tables

```
data_karyawan
negara
```

---

# ⚙️ Installation

## 1 Clone Repository

```bash
git clone https://github.com/yourusername/data-karyawan-backend.git
```

---

## 2 Open Project

```bash
cd data-karyawan-backend
```

---

## 3 Restore Packages

```bash
dotnet restore
```

---

## 4 Configure Database

Open

```
appsettings.json
```

Example

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "server=localhost;port=3306;database=pt_istidata_brian;user=root;password=;"
  }
}
```

---

## 5 Run Project

```bash
dotnet run
```

or

```
F5
```

---

# 🚀 Application Flow

```
Browser

        │

        ▼

HomeController

        │

        ▼

Repository

        │

        ▼

Entity Framework Core

        │

        ▼

MySQL Database
```

---

# 📖 CRUD Flow

## Create

```
Modal Tambah

↓

HomeController

↓

Repository

↓

Database
```

---

## Read

```
HomeController

↓

Repository

↓

Database

↓

Table
```

---

## Update

```
Modal Edit

↓

Repository

↓

Database
```

---

## Delete

```
Modal Delete

↓

Repository

↓

Database
```

---

# 📋 Modules

## Dashboard

Display employee list.

---

## Employee

Manage employee data.

Functions

- Add
- Edit
- Delete
- Detail

---

## Search

Search employee by

- NIK
- Name

---

## Country

Country data is stored inside

```
negara
```

table and used by employee data.

---

# 📷 User Interface

Main Components

- Search Section
- Data Table
- Pagination
- Add Modal
- Edit Modal
- Detail Modal
- Delete Confirmation Modal

---

# 📌 Coding Pattern

The project follows the MVC architecture.

```
Controller

↓

Repository

↓

DbContext

↓

Database
```

Benefits

- Clean Code
- Easy Maintenance
- Separation of Concerns
- Reusable Components
- Easy Testing

---

# 📦 NuGet Packages

```
Microsoft.EntityFrameworkCore

Microsoft.EntityFrameworkCore.Design

Pomelo.EntityFrameworkCore.MySql

Microsoft.EntityFrameworkCore.Tools
```

---

# 🔐 Validation

Employee validation includes

- NIK
- Full Name
- Date of Birth
- Gender
- Country
- Address

---

# 📈 Future Improvements

- Authentication
- Authorization
- Role Management
- Dashboard
- Export Excel
- Export PDF
- Import Excel
- Upload Photo
- Search with AJAX
- Server-side DataTables
- Logging
- Unit Test
- API Versioning

---

# 👨‍💻 Developer

Developed using

- ASP.NET Core MVC
- Entity Framework Core
- MySQL
- Bootstrap
- jQuery
- DataTables

---

# 📄 License

This project is intended for educational purposes and portfolio demonstrations.