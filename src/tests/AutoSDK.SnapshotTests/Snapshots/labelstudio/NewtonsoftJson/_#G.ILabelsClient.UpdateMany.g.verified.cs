//HintName: G.ILabelsClient.UpdateMany.g.cs
#nullable enable

namespace G
{
    public partial interface ILabelsClient
    {
        /// <summary>
        /// Bulk update labels<br/>
        ///         If you want to update the labels in saved annotations, use this endpoint.<br/>
        ///         
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task UpdateManyAsync(
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}