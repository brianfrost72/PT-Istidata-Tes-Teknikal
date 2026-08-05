using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using data_karyawan_backend.Data;
using data_karyawan_backend.Models;

namespace data_karyawan_backend.Controllers;

public class HomeController : Controller
{
    private readonly AppDbContext _context;

    public HomeController(AppDbContext context)
    {
        _context = context;
    }

    //==========================
    // INDEX
    //==========================
    public IActionResult Index()
{
    ViewBag.Negara = _context.Negaras
        .OrderBy(x => x.Negara1)
        .ToList();

    var data = _context.DataKaryawans
        .OrderByDescending(x => x.Id)
        .ToList();

    return View(data);
}

    //==========================
    // DETAIL
    //==========================
    [HttpGet]
    public IActionResult GetById(int id)
    {
        var data = _context.DataKaryawans
            .FirstOrDefault(x => x.Id == id);

        if (data == null)
            return NotFound();

        return Json(data);
    }

    //==========================
    // CREATE
    //==========================
    [HttpPost]
    public IActionResult Create(DataKaryawan model)
    {
        try
        {
            model.DibuatTgl = DateTime.Now;

            _context.DataKaryawans.Add(model);

            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
        catch (Exception ex)
        {
            return Content(ex.ToString());
        }
    }

    //==========================
    // EDIT
    //==========================
    [HttpPost]
    public IActionResult Edit(DataKaryawan model)
    {
        try
        {
            var data = _context.DataKaryawans
                .FirstOrDefault(x => x.Id == model.Id);

            if (data == null)
                return NotFound();

            data.Nik = model.Nik;
            data.Nama = model.Nama;
            data.TanggalLahir = model.TanggalLahir;
            data.JenisKelamin = model.JenisKelamin;
            data.Alamat = model.Alamat;
            data.IdNegara = model.IdNegara;

            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
        catch (Exception ex)
        {
            return Content(ex.ToString());
        }
    }

    //==========================
    // DELETE
    //==========================
    [HttpPost]
    public IActionResult Delete(int id)
    {
        try
        {
            var data = _context.DataKaryawans
                .FirstOrDefault(x => x.Id == id);

            if (data == null)
                return NotFound();

            _context.DataKaryawans.Remove(data);

            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
        catch (Exception ex)
        {
            return Content(ex.ToString());
        }
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel
        {
            RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
        });
    }
}