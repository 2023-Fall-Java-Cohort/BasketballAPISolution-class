using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using BasketballDataModel;
using BasketballApp.Repositories;

namespace BasketballApp.Controllers { 
    public class PlayersController : Controller
    {
        private readonly IPlayersRepository players;
        private readonly ITeamsRepository teams;
        private readonly IPositionsRepository positions;
        private readonly ILogger<PlayersController> logger;
        private readonly IErrorHandler errorHandler;

        public PlayersController(IPlayersRepository players, ITeamsRepository teams, IPositionsRepository positions, ILogger<PlayersController> logger, IErrorHandler errorHandler)
        {
            this.players = players;
            this.teams = teams;
            this.positions = positions;
            this.logger = logger;
            this.errorHandler = errorHandler;
        }

        // GET: Players
        public async Task<IActionResult> Index(CancellationToken cancellation = default(CancellationToken))
        {
            try
            {
                return View(await players.GetAllAsync(cancellation));
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"{ex.Message} Get all Players failed");
                errorHandler.reportErrors(ex);
            }
            return BadRequest("Get all Players failed");

        }

        // GET: Players/Details/5
        public async Task<IActionResult> Details(int? id, CancellationToken cancellation = default(CancellationToken))
        {
            PlayerModel? playerModel = null;
            if (id is null)
            {
                return NotFound();
            }
            try
            {
                playerModel = await players.GetAsync(id.Value, cancellation);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"{ex.Message} Get player failed");
                errorHandler.reportErrors(ex);
            }

            if (playerModel is null)
            {
                return NotFound();
            }

            return View(playerModel);
        }

        // GET: Players/Create
        public async Task<IActionResult> Create(CancellationToken cancellation = default(CancellationToken))
        {
            PlayerModel playerModel = new PlayerModel();
            ViewData["PositionId"] = new SelectList(await positions.GetAllAsync(cancellation), "Id", "Name");
            ViewData["TeamId"] = new SelectList(await teams.GetAllAsync(cancellation), "Id", "Name");
            return View(playerModel);
        }

        // POST: Players/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NationalRank,Birthdate,IsActive,PositionId,Salary,TeamId,Id,Name")] PlayerModel playerModel, CancellationToken cancellation = default(CancellationToken))
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await players.AddAsync(playerModel, cancellation);
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    logger.LogError(ex, $"{ex.Message} Create Player failed with {playerModel}");
                    errorHandler.reportErrors(ex);
                }
            }
            ViewData["PositionId"] = new SelectList(await positions.GetAllAsync(cancellation), "Id", "Name", playerModel.PositionId);
            ViewData["TeamId"] = new SelectList(await teams.GetAllAsync(cancellation), "Id", "Name", playerModel.TeamId);
            return View(playerModel);
        }

        // GET: Players/Edit/5
        public async Task<IActionResult> Edit(int? id, CancellationToken cancellation = default(CancellationToken))
        {
            PlayerModel? playerModel = null;
            if (!id.HasValue)
            {
                return NotFound();
            }

            try
            {
                playerModel = await players.GetAsync(id.Value, cancellation);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"{ex.Message} Edit Player failed for {id}");
                errorHandler.reportErrors(ex);
            }

            if (playerModel is null)
            {
                return NotFound();
            }
            ViewData["PositionId"] = new SelectList(await positions.GetAllAsync(cancellation), "Id", "Name", playerModel.PositionId);
            ViewData["TeamId"] = new SelectList(await teams.GetAllAsync(cancellation), "Id", "Name", playerModel.TeamId);
            return View(playerModel);
        }

        // POST: Players/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("NationalRank,Birthdate,IsActive,PositionId,Salary,TeamId,Id,Name")] PlayerModel playerModel, CancellationToken cancellation = default(CancellationToken))
        {
            if (id != playerModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await players.UpdateAsync(playerModel, cancellation);
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    logger.LogError(ex, $"{ex.Message} Edit Player failed for {id}");
                    errorHandler.reportErrors(ex);
                }
            }
            ViewData["PositionId"] = new SelectList(await positions.GetAllAsync(cancellation), "Id", "Name", playerModel.PositionId);
            ViewData["TeamId"] = new SelectList(await teams.GetAllAsync(cancellation), "Id", "Name", playerModel.TeamId);
            return View(playerModel);
        }

        // GET: Players/Delete/5
        public async Task<IActionResult> Delete(int? id, CancellationToken cancellation = default(CancellationToken))
        {
            PlayerModel? playerModel = null;
            if (!id.HasValue)
            {
                return NotFound();
            }

            try
            {
                playerModel = await players.GetAsync(id.Value, cancellation);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"{ex.Message} Delete Player failed for {id}");
                errorHandler.reportErrors(ex);
            }
            if (playerModel is null)
            {
                return NotFound();
            }

            return View(playerModel);
        }

        // POST: Players/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id, CancellationToken cancellation = default(CancellationToken))
        {
            try
            {
                PlayerModel? playerModel = await players.GetAsync(id, cancellation);
                if (playerModel != null)
                {
                    await players.DeleteAsync(playerModel.Id, cancellation);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"{ex.Message} Delete Player failed for {id}");
                errorHandler.reportErrors(ex);
            }

            return RedirectToAction(nameof(Index));
        }

    }
}
