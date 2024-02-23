using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BasketballDataModel;
using BasketballApp.Repositories;

namespace BasketballApp.Controllers
{
    public class TeamsController : Controller
    {
        private readonly ITeamsRepository teams;
        private readonly ILogger<TeamsController> logger;
        private readonly IErrorHandler errorHandler;

        public TeamsController(ITeamsRepository teams, ILogger<TeamsController> logger, IErrorHandler errorHandler)
        {
            this.teams = teams;
            this.logger = logger;
            this.errorHandler = errorHandler;
        } 


        // GET: TeamModels
        public async Task<IActionResult> Index(CancellationToken cancellation = default(CancellationToken))
        {
            try
            {
                return View(await teams.GetAllAsync(cancellation));
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"{ex.Message} Get all teams failed");
                this.errorHandler.reportErrors(ex);
            }
            return BadRequest($"Get all teams failed");
        }

        // GET: TeamModels/Details/5
        public async Task<IActionResult> Details(int? id, CancellationToken cancellation = default(CancellationToken))
        {
            TeamModel? teamModel = null;

            if (id == null)
            {
                return NotFound();
            }
            try
            {
                teamModel = await teams.GetAsync(id.Value, cancellation);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"{ex.Message} Get team failed for id {id}");
                this.errorHandler.reportErrors(ex);
            }
            if (teamModel is null)
            {
                return NotFound();
            }

            return View(teamModel);
        }

        // GET: TeamModels/Create
        public IActionResult Create()
        {
            TeamModel teamModel = new TeamModel();
 
            return View(teamModel);
        }

        // POST: TeamModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NationalRank,SeasonWins,SeasonLoss,Id,Name")] TeamModel teamModel, CancellationToken cancellation = default(CancellationToken))
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await teams.AddAsync(teamModel, cancellation);
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    logger.LogError(ex, $"{ex.Message} create team failed for id {teamModel}");
                    this.errorHandler.reportErrors(ex);
                }
            }
          
            return View(teamModel);
        }

        // GET: TeamModels/Edit/5
        public async Task<IActionResult> Edit(int? id, CancellationToken cancellation = default(CancellationToken))
        {
            TeamModel? teamModel = null;
            if (!id.HasValue)
            {
                return NotFound();
            }
            try
            {
                teamModel = await teams.GetAsync(id.Value, cancellation);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"{ex.Message} Edit coach failed for id {teamModel}");
                this.errorHandler.reportErrors(ex);
            }
            if (teamModel == null)
            {
                return NotFound();
            }
          

            return View(teamModel);
        }

        // POST: TeamModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("NationalRank,SeasonWins,SeasonLoss,Id,Name")] TeamModel teamModel, CancellationToken cancellation = default(CancellationToken))
        {
            if (id != teamModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await teams.UpdateAsync(teamModel, cancellation);
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    logger.LogError(ex, $"{ex.Message} Edit coach failed for id {teamModel}");
                    this.errorHandler.reportErrors(ex);
                }
            }
       
            return View(teamModel);
        }

        // GET: TeamModels/Delete/5
        public async Task<IActionResult> Delete(int? id, CancellationToken cancellation = default(CancellationToken))
        {
            TeamModel? teamModel = null;
            if (!id.HasValue)
            {
                return NotFound();
            }

            try
            {
                teamModel = await teams.GetAsync(id.Value, cancellation);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"{ex.Message} Delete team failed for id {teamModel}");
                this.errorHandler.reportErrors(ex);
            }


            if (teamModel == null)
            {
                return NotFound();
            }

            return View(teamModel);
        }

        // POST: TeamModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id, CancellationToken cancellation = default(CancellationToken))
        {
            TeamModel? teamModel = null;
            try
            {
                teamModel = await teams.GetAsync(id, cancellation);
                if (teamModel != null)
                {
                    await teams.DeleteAsync(teamModel.Id, cancellation);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"{ex.Message} Delete team failed for id {teamModel}");
                this.errorHandler.reportErrors(ex);
            }

            return RedirectToAction(nameof(Index));
        }

    }
}
