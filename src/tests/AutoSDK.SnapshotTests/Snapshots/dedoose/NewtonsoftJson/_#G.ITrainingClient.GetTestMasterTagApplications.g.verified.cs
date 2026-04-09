//HintName: G.ITrainingClient.GetTestMasterTagApplications.g.cs
#nullable enable

namespace G
{
    public partial interface ITrainingClient
    {
        /// <summary>
        /// GetTestMasterTagApplications<br/>
        /// GetTestMasterTagApplications
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.TrainingTestMasterTagApp>> GetTestMasterTagApplicationsAsync(

            global::G.GetTestMasterTagApplicationsRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// GetTestMasterTagApplications<br/>
        /// GetTestMasterTagApplications
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="testId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.TrainingTestMasterTagApp>> GetTestMasterTagApplicationsAsync(
            global::System.Guid projectId,
            global::System.Guid testId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}