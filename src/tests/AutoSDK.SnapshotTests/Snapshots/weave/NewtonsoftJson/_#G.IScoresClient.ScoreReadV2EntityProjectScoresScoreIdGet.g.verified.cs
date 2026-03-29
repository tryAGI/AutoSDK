//HintName: G.IScoresClient.ScoreReadV2EntityProjectScoresScoreIdGet.g.cs
#nullable enable

namespace G
{
    public partial interface IScoresClient
    {
        /// <summary>
        /// Score Read<br/>
        /// Read a score.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="project"></param>
        /// <param name="scoreId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ScoreReadRes> ScoreReadV2EntityProjectScoresScoreIdGetAsync(
            string entity,
            string project,
            string scoreId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}