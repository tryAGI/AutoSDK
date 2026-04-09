//HintName: G.IWorkspacesClient.UpdateTagValue.g.cs
#nullable enable

namespace G
{
    public partial interface IWorkspacesClient
    {
        /// <summary>
        /// Update Tag Value
        /// </summary>
        /// <param name="tagKeyId"></param>
        /// <param name="tagValueId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TagValue> UpdateTagValueAsync(
            global::System.Guid tagKeyId,
            global::System.Guid tagValueId,

            global::G.TagValueUpdate request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Tag Value
        /// </summary>
        /// <param name="tagKeyId"></param>
        /// <param name="tagValueId"></param>
        /// <param name="value"></param>
        /// <param name="description"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TagValue> UpdateTagValueAsync(
            global::System.Guid tagKeyId,
            global::System.Guid tagValueId,
            string? value = default,
            string? description = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}