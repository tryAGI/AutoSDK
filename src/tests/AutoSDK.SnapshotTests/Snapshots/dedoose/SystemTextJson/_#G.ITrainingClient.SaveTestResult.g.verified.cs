//HintName: G.ITrainingClient.SaveTestResult.g.cs
#nullable enable

namespace G
{
    public partial interface ITrainingClient
    {
        /// <summary>
        /// SaveTestResult<br/>
        /// SaveTestResult
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TrainingTestResult> SaveTestResultAsync(
            global::G.SaveTestResultRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// SaveTestResult<br/>
        /// SaveTestResult
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="traineeUserId"></param>
        /// <param name="testId"></param>
        /// <param name="overallRating"></param>
        /// <param name="traineeTagApps"></param>
        /// <param name="completed"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TrainingTestResult> SaveTestResultAsync(
            global::System.Guid projectId,
            global::System.Guid traineeUserId,
            global::System.Guid testId,
            double overallRating,
            global::System.Collections.Generic.IList<global::G.TrainingTestTagApp> traineeTagApps,
            bool completed,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}