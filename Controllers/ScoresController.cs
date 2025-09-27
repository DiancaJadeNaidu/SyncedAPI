using SyncedAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using SyncedAPI.Models;

namespace SyncedAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ScoresController : ControllerBase
    {
        private readonly ScoreRepository _repository;

        public ScoresController(ScoreRepository repository)
        {
            _repository = repository;
        }

        // POST: api/scores
        [HttpPost]
        public async Task<IActionResult> PostScore([FromBody] Score score)
        {
            if (score == null) return BadRequest(new { message = "Score data is required." });

            // Timestamp will automatically use DateTime.UtcNow from model
            await _repository.AddScoreAsync(score);
            return Ok(new { message = "Score added successfully!", score });
        }

        // GET: api/scores/user/{userId}
        [HttpGet("user/{userId}")]
        public async Task<IActionResult> GetUserScores(string userId)
        {
            var scores = await _repository.GetScoresByUserAsync(userId);
            if (scores == null || !scores.Any()) return NotFound(new { message = "No scores found for this user." });
            return Ok(scores);
        }

        // GET: api/scores/friend/{friendId}
        [HttpGet("friend/{friendId}")]
        public async Task<IActionResult> GetFriendScores(string friendId)
        {
            var scores = await _repository.GetFriendScoresAsync(friendId);
            if (scores == null || !scores.Any()) return NotFound(new { message = "No scores found for this friend." });
            return Ok(scores);
        }
    }
}
