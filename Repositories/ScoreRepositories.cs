using SyncedAPI.Data;
using SyncedAPI.Models;
using MongoDB.Driver;

namespace SyncedAPI.Repositories
{
    public class ScoreRepository
    {
        private readonly IMongoCollection<Score> _scores;

        public ScoreRepository(MongoDBContext context)
        {
            _scores = context.GetCollection<Score>("Scores");
        }

        public async Task<List<Score>> GetScoresByUserAsync(string userId)
        {
            return await _scores.Find(s => s.UserId == userId).SortByDescending(s => s.Timestamp).ToListAsync();
        }

        public async Task AddScoreAsync(Score score)
        {
            await _scores.InsertOneAsync(score);
        }

        public async Task<List<Score>> GetFriendScoresAsync(string friendId)
        {
            return await _scores.Find(s => s.FriendId == friendId).SortByDescending(s => s.Timestamp).ToListAsync();
        }
    }
}
