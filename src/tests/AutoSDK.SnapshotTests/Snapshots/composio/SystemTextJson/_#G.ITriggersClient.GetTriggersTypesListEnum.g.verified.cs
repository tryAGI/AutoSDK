//HintName: G.ITriggersClient.GetTriggersTypesListEnum.g.cs
#nullable enable

namespace G
{
    public partial interface ITriggersClient
    {
        /// <summary>
        /// List trigger type enums<br/>
        /// Retrieves a list of all available trigger type enum values that can be used across the API from latest versions of the toolkit only
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<string>> GetTriggersTypesListEnumAsync(
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}