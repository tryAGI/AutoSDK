//HintName: G.ITrainingClient.GetTestExcerpts.g.cs
#nullable enable

namespace G
{
    public partial interface ITrainingClient
    {
        /// <summary>
        /// GetTestExcerpts<br/>
        /// GetTestExcerpts
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.TrainingTestExcerpt>> GetTestExcerptsAsync(
            global::G.GetTestExcerptsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GetTestExcerpts<br/>
        /// GetTestExcerpts
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="testId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.TrainingTestExcerpt>> GetTestExcerptsAsync(
            global::System.Guid projectId,
            global::System.Guid testId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}