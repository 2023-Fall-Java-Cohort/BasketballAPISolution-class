using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using BasketballDataModel;
using BasketballApp.Repositories;
using System.Collections.Generic;
using System;

namespace BasketballApp.Controllers
{
    public class CoachesController : Controller
    {
        private readonly ICoachesRepository coaches;
        private readonly ITeamsRepository teams;
        private readonly ILogger<CoachesController> logger;
        private readonly IErrorHandler errorHandler;

        public CoachesController(ICoachesRepository coaches, ITeamsRepository teams, ILogger<CoachesController> logger, IErrorHandler errorHandler)
        {
            this.coaches = coaches;
            this.teams = teams;
            this.logger = logger;
            this.errorHandler = errorHandler;
        }

        // GET: CoachModels
        public async Task<IActionResult> Index(CancellationToken cancellation = default(CancellationToken))
        {
            try
            {
                return View(await coaches.GetAllAsync(cancellation));
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"{ex.Message} Get all coaches failed");
                this.errorHandler.reportErrors(ex);
            }
            return BadRequest($"Get all coaches failed");
        }

        // GET: CoachModels/Details/5
        public async Task<IActionResult> Details(int? id, CancellationToken cancellation = default(CancellationToken))
        {
            CoachModel? coachModel = null;

            if (id == null)
            {
                return NotFound();
            }
            try
            {
                coachModel = await coaches.GetAsync(id.Value, cancellation);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"{ex.Message} Get coach failed for id {id}");
                this.errorHandler.reportErrors(ex);
            }
            if (coachModel is null)
            {
                return NotFound();
            }

            return View(coachModel);
        }

        // GET: CoachModels/Create
        public async Task<IActionResult> Create(CancellationToken cancellation = default(CancellationToken))
        {
            CoachModel coachModel = new CoachModel();
            Array? enumList = Enum.GetValues(typeof(CoachTitle));
            ViewData["CoachTitle"] = new SelectList(enumList);
            ViewData["TeamId"] = new SelectList(await teams.GetAllAsync(cancellation), "Id", "Name");
            return View(coachModel);
        }

        // POST: CoachModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Title,TeamId,Id,Name")] CoachModel coachModel, CancellationToken cancellation = default(CancellationToken))
        {

            if (ModelState.IsValid)
            {
                try
                {
                    await coaches.AddAsync(coachModel, cancellation);
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    logger.LogError(ex, $"{ex.Message} create coach failed for id {coachModel}");
                    this.errorHandler.reportErrors(ex);
                }
            }
            Array? enumList = Enum.GetValues(typeof(CoachTitle));
            ViewData["CoachTitle"] = new SelectList(enumList,coachModel.Title);
            ViewData["TeamId"] = new SelectList(await teams.GetAllAsync(cancellation), "Id", "Name", coachModel.TeamId);
            return View(coachModel);
        }

        // GET: CoachModels/Edit/5
        public async Task<IActionResult> Edit(int? id, CancellationToken cancellation = default(CancellationToken))
        {
            CoachModel? coachModel = null;
            if (!id.HasValue)
            {
                return NotFound();
            }
            try
            {
                coachModel = await coaches.GetAsync(id.Value, cancellation);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"{ex.Message} Edit coach failed for id {coachModel}");
                this.errorHandler.reportErrors(ex);
            }
            if (coachModel == null)
            {
                return NotFound();
            }
            Array? enumList = Enum.GetValues(typeof(CoachTitle));
            ViewData["CoachTitle"] = new SelectList(enumList);
            ViewData["TeamId"] = new SelectList(await teams.GetAllAsync(cancellation), "Id", "Name", coachModel.TeamId);

            return View(coachModel);
        }

        // POST: CoachModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Title,TeamId,Id,Name")] CoachModel coachModel, CancellationToken cancellation = default(CancellationToken))
        {
            if (id != coachModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await coaches.UpdateAsync(coachModel, cancellation);
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    logger.LogError(ex, $"{ex.Message} Edit coach failed for id {coachModel}");
                    this.errorHandler.reportErrors(ex);
                }
            }
            Array? enumList = Enum.GetValues(typeof(CoachTitle));
            ViewData["CoachTitle"] = new SelectList(enumList);
            ViewData["TeamId"] = new SelectList(await teams.GetAllAsync(cancellation), "Id", "Name", coachModel.TeamId);
            return View(coachModel);
        }

        // GET: CoachModels/Delete/5
        public async Task<IActionResult> Delete(int? id, CancellationToken cancellation = default(CancellationToken))
        {
            CoachModel? coachModel = null;
            if (!id.HasValue)
            {
                return NotFound();
            }

            try
            {
                coachModel = await coaches.GetAsync(id.Value, cancellation);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"{ex.Message} Delete coach failed for id {coachModel}");
                this.errorHandler.reportErrors(ex);
            }


            if (coachModel == null)
            {
                return NotFound();
            }

            return View(coachModel);
        }

        // POST: CoachModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id, CancellationToken cancellation = default(CancellationToken))
        {
            CoachModel? coachModel = null;
            try
            {
                coachModel = await coaches.GetAsync(id, cancellation);
                if (coachModel != null)
                {
                    await coaches.DeleteAsync(coachModel.Id, cancellation);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"{ex.Message} Delete coach failed for id {coachModel}");
                this.errorHandler.reportErrors(ex);
            }

            return RedirectToAction(nameof(Index));
        }

    }
}
