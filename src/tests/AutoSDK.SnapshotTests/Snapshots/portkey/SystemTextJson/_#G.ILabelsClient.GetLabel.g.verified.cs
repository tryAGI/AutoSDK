//HintName: G.ILabelsClient.GetLabel.g.cs
#nullable enable

namespace G
{
    public partial interface ILabelsClient
    {
        /// <summary>
        /// Get a label by ID<br/>
        /// Returns a specific label by its ID
        /// </summary>
        /// <param name="labelId"></param>
        /// <param name="organisationId"></param>
        /// <param name="workspaceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Label> GetLabelAsync(
            global::System.Guid labelId,
            global::System.Guid? organisationId = default,
            string? workspaceId = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}