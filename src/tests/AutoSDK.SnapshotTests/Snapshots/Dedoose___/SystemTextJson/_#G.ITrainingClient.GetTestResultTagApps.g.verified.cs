//HintName: G.ITrainingClient.GetTestResultTagApps.g.cs
#nullable enable

namespace G
{
    public partial interface ITrainingClient
    {
        /// <summary>
        /// GetTestResultTagApps<br/>
        /// GetTestResultTagApps
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.TrainingTestTagApp>> GetTestResultTagAppsAsync(
            global::G.GetTestResultTagAppsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GetTestResultTagApps<br/>
        /// GetTestResultTagApps
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="testId"></param>
        /// <param name="testResultId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.TrainingTestTagApp>> GetTestResultTagAppsAsync(
            global::System.Guid projectId,
            global::System.Guid testId,
            global::System.Guid testResultId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}