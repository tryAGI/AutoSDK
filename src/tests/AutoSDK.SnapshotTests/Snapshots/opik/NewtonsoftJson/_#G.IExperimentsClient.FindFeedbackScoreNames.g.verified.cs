//HintName: G.IExperimentsClient.FindFeedbackScoreNames.g.cs
#nullable enable

namespace G
{
    public partial interface IExperimentsClient
    {
        /// <summary>
        /// Find Feedback Score names<br/>
        /// Find Feedback Score names
        /// </summary>
        /// <param name="experimentIds"></param>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.FeedbackScoreNamesPublic> FindFeedbackScoreNamesAsync(
            string? experimentIds = default,
            global::System.Guid? projectId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}