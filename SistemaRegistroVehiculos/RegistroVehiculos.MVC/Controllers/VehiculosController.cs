using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RegistroVehiculos.MVC.Data;
using RegistroVehiculos.MVC.Models;

namespace RegistroVehiculos.MVC.Controllers
{
    public class VehiculosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VehiculosController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var vehiculos = await _context.Vehiculos.ToListAsync();
            return View(vehiculos);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Vehiculo vehiculo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vehiculo);
                await _context.SaveChangesAsync();
                TempData["Success"] = "Vehículo registrado exitosamente";
                return RedirectToAction(nameof(Index));
            }
            return View(vehiculo);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var vehiculo = await _context.Vehiculos.FindAsync(id);
            if (vehiculo == null)
                return NotFound();
            return View(vehiculo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Vehiculo vehiculo)
        {
            if (id != vehiculo.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vehiculo);
                    await _context.SaveChangesAsync();
                    TempData["Success"] = "Vehículo actualizado exitosamente";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VehiculoExists(vehiculo.Id))
                        return NotFound();
                    throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(vehiculo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var vehiculo = await _context.Vehiculos.FindAsync(id);
            if (vehiculo != null)
            {
                _context.Vehiculos.Remove(vehiculo);
                await _context.SaveChangesAsync();
                TempData["Success"] = "Vehículo eliminado exitosamente";
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ToggleStatus(int id)
        {
            var vehiculo = await _context.Vehiculos.FindAsync(id);
            if (vehiculo != null)
            {
                vehiculo.Activo = !vehiculo.Activo;
                await _context.SaveChangesAsync();
                TempData["Success"] = $"Vehículo {(vehiculo.Activo ? "activado" : "desactivado")} exitosamente";
            }
            return RedirectToAction(nameof(Index));
        }

        private bool VehiculoExists(int id)
        {
            return _context.Vehiculos.Any(e => e.Id == id);
        }
    }
}
