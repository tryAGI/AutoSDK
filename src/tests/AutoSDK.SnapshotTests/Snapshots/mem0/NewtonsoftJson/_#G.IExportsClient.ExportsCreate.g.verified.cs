//HintName: G.IExportsClient.ExportsCreate.g.cs
#nullable enable

namespace G
{
    public partial interface IExportsClient
    {
        /// <summary>
        /// Create an export job with schema<br/>
        /// Create a structured export of memories based on a provided schema.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ExportsCreateResponse> ExportsCreateAsync(

            global::G.ExportsCreateRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an export job with schema<br/>
        /// Create a structured export of memories based on a provided schema.
        /// </summary>
        /// <param name="schema">
        /// Schema definition for the export
        /// </param>
        /// <param name="filters">
        /// Filters to apply while exporting memories. Available fields are: user_id, agent_id, app_id, run_id.
        /// </param>
        /// <param name="orgId">
        /// Filter exports by organization ID.
        /// </param>
        /// <param name="projectId">
        /// Filter exports by project ID.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ExportsCreateResponse> ExportsCreateAsync(
            object schema,
            global::G.ExportsCreateRequestFilters? filters = default,
            string? orgId = default,
            string? projectId = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}