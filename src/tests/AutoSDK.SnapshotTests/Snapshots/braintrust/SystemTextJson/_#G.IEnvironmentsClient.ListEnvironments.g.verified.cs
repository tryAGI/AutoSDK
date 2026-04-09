//HintName: G.IEnvironmentsClient.ListEnvironments.g.cs
#nullable enable

namespace G
{
    public partial interface IEnvironmentsClient
    {
        /// <summary>
        /// List environments<br/>
        /// List out all environments. The environments are sorted by creation date, with the most recently-created environments first.
        /// </summary>
        /// <param name="ids">
        /// Filter by environment IDs. Supports a single ID or multiple values.
        /// </param>
        /// <param name="name"></param>
        /// <param name="orgName">
        /// Filter search results to within a particular organization
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListEnvironmentsResponse> ListEnvironmentsAsync(
            global::G.AnyOf<global::System.Guid?, global::System.Collections.Generic.IList<global::System.Guid>>? ids = default,
            string? name = default,
            string? orgName = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}