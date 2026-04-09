//HintName: G.IFunctionClient.GetAttachedFunction.g.cs
#nullable enable

namespace G
{
    public partial interface IFunctionClient
    {
        /// <summary>
        /// Get attached function<br/>
        /// Returns an attached function by name.
        /// </summary>
        /// <param name="tenant"></param>
        /// <param name="database"></param>
        /// <param name="collectionId"></param>
        /// <param name="functionName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetAttachedFunctionResponse> GetAttachedFunctionAsync(
            string tenant,
            string database,
            string collectionId,
            string functionName,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}