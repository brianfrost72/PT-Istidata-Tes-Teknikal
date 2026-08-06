using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using data_karyawan_backend.Models;
using data_karyawan_backend.Repositories;

namespace data_karyawan_backend.Controllers;

public class HomeController : Controller
{
    private readonly IDataKaryawanRepository _karyawanRepository;
    private readonly INegaraRepository _negaraRepository;

    public HomeController(
        IDataKaryawanRepository karyawanRepository,
        INegaraRepository negaraRepository)
    {
        _karyawanRepository = karyawanRepository;
        _negaraRepository = negaraRepository;
    }

    //==========================
    // INDEX
    //==========================
    public IActionResult Index()
    {
        ViewBag.Negara = _negaraRepository.GetAll();

        var data = _karyawanRepository.GetAll();

        return View(data);
    }

    //==========================
    // DETAIL
    //==========================
    [HttpGet]
    public IActionResult GetById(int id)
    {
        var data = _karyawanRepository.GetById(id);

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

            _karyawanRepository.Add(model);

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
            _karyawanRepository.Update(model);

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
            _karyawanRepository.Delete(id);

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

    [ResponseCache(Duration = 0,
        Location = ResponseCacheLocation.None,
        NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel
        {
            RequestId = Activity.Current?.Id ??
                        HttpContext.TraceIdentifier
        });
    }
}