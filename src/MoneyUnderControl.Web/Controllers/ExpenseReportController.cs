using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoneyUnderControl.Application.Interfaces;
using MoneyUnderControl.Application.ViewModels;

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
        [HttpGet]
        public async Task<ActionResult> Index()
        {
            return View(await _service.GetAll());
        }

        // GET: ExpenseReportController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ExpenseReportController/Create
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
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ExpenseReportController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ExpenseReportController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ExpenseReportController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
