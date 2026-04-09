//HintName: G.IObjectivesClient.PatchObjectives.g.cs
#nullable enable

namespace G
{
    public partial interface IObjectivesClient
    {
        /// <summary>
        /// Patch Objective<br/>
        /// Update an objective using JSON Patch operations.
        /// </summary>
        /// <param name="objectivesId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Objectives> PatchObjectivesAsync(
            string objectivesId,

            global::System.Collections.Generic.IList<global::G.JsonPatchOperation> request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}