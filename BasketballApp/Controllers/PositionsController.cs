using Microsoft.AspNetCore.Mvc;
using BasketballDataModel;
using BasketballApp.Repositories;

namespace BasketballApp.Controllers
{
    public class PositionsController : Controller
    {
        private readonly IPositionsRepository positions;
        private readonly ILogger<PositionsController> logger;
        private readonly IErrorHandler errorHandler;

        public PositionsController(IPositionsRepository positions, ILogger<PositionsController> logger, IErrorHandler errorHandler)
        {
            this.positions = positions;
            this.logger = logger;
            this.errorHandler = errorHandler;
        }

        // GET: Positions
        public async Task<IActionResult> Index(CancellationToken cancellation = default(CancellationToken))
        {
            try
            {
                return View(await positions.GetAllAsync(cancellation));
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"{ex.Message} Get all Positions failed");
                errorHandler.reportErrors(ex);
            }
            return BadRequest("Get all Positions failed");
        }

        // GET: Positions/Details/5
        public async Task<IActionResult> Details(int? id, CancellationToken cancellation = default(CancellationToken))
        {
            PositionModel? positionModel = null;
            if (!id.HasValue)
            {
                return NotFound();
            }
            try
            {
                positionModel = await positions.GetAsync(id.Value, cancellation);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"{ex.Message} Get Position id {id} failed");
                errorHandler.reportErrors(ex);
            }
            if (positionModel is null)
            {
                return NotFound();
            }

            return View(positionModel);
        }

        // GET: Positions/Create
        public IActionResult Create(CancellationToken cancellation = default(CancellationToken))
        {
            PositionModel positionModel = new PositionModel();
            return View(positionModel);
        }

        // POST: Positions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] PositionModel positionModel, CancellationToken cancellation = default(CancellationToken))
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await positions.AddAsync(positionModel, cancellation);
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    logger.LogError(ex, $"{ex.Message} Create position failed with {positionModel}");
                    errorHandler.reportErrors(ex);
                }

            }
            return View(positionModel);
        }

        // GET: Positions/Edit/5
        public async Task<IActionResult> Edit(int? id, CancellationToken cancellation = default(CancellationToken))
        {
            PositionModel? positionModel = null;
            if (!id.HasValue)
            {
                return NotFound();
            }
            try
            {
                positionModel = await positions.GetAsync(id.Value, cancellation);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"{ex.Message} Edit position failed with Id {id}");
                errorHandler.reportErrors(ex);
            }
            if (positionModel is null)
            {
                return NotFound();
            }
            return View(positionModel);
        }

        // POST: Positions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] PositionModel positionModel, CancellationToken cancellation = default(CancellationToken))
        {
            if (id != positionModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await positions.UpdateAsync(positionModel, cancellation);
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    logger.LogError(ex, $"{ex.Message} Edit position failed for Id {id}");
                    errorHandler.reportErrors(ex);
                }
            }
            return View(positionModel);
        }

        // GET: Positions/Delete/5
        public async Task<IActionResult> Delete(int? id, CancellationToken cancellation = default(CancellationToken))
        {
            PositionModel? positionModel = null;
            if (!id.HasValue)
            {
                return NotFound();
            }
            try { 
                positionModel = await positions.GetAsync(id.Value, cancellation);
            } 
            catch (Exception ex) 
            {
                logger.LogError(ex, $"{ex.Message} Error finding position for Id {id}");
                errorHandler.reportErrors(ex);
            }
            if (positionModel == null)
            {
                return NotFound();
            }

            return View(positionModel);
        }

        // POST: Positions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id, CancellationToken cancellation = default(CancellationToken))
        {
            try
            {
                PositionModel? positionModel = await positions.GetAsync(id, cancellation);
                if (positionModel != null)
                {
                    await positions.DeleteAsync(positionModel.Id, cancellation);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"{ex.Message} Delete position failed for Id {id}");
                errorHandler.reportErrors(ex);
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
