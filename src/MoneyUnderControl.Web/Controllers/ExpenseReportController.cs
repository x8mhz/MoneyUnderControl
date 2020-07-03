using Microsoft.AspNetCore.Mvc;
using MoneyUnderControl.Application.Interfaces;
using MoneyUnderControl.Application.ViewModels;
using System;
using System.Threading.Tasks;

namespace MoneyUnderControl.Web.Controllers
{
    public class ExpenseReportController : Controller
    {
        private readonly IExpenseReportService _service;

        public ExpenseReportController(IExpenseReportService service)
        {
            _service = service;
        }

        // GET: ExpenseReportController
        [HttpGet()]
        public async Task<ActionResult> Index()
        {
            return View(await _service.GetAll());
        }

        // GET: ExpenseReportController/Details/5
        [HttpGet("Detalhes/{id}")]
        public async Task<ActionResult> Details(Guid? id)
        {
            if (id == null) return NotFound();
            var viewModel = await _service.GetById(id.Value);
            if (viewModel == null) return NotFound();

            return View(viewModel);
        }

        // GET: ExpenseReportController/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: ExpenseReportController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ExpenseReportViewModel viewModel)
        {
            if (!ModelState.IsValid) return View(viewModel);

            await _service.Register(viewModel);
            return View(viewModel);
        }

        // GET: ExpenseReportController/Edit/5
        [HttpGet("editar/{id}")]
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null) return NotFound();

            var viewModel = await _service.GetById(id.Value);
            if (viewModel == null) return NotFound();

            return View(viewModel);
        }

        // POST: ExpenseReportController/Edit/5
        [HttpPost("editar/{id}")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(ExpenseReportViewModel viewModel)
        {
            if (!ModelState.IsValid) return View(viewModel);

            await _service.Update(viewModel);

            return View(viewModel);
        }

        // GET: ExpenseReportController/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null) return NotFound();
            var viewModel = await _service.GetById(id.Value);
            if (viewModel == null) return NotFound();

            return View(viewModel);
        }

        // POST: ExpenseReportController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _service.Remove(id);

            return RedirectToAction("Index");
        }
    }
}
