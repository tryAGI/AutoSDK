//HintName: G.IAliasOperationsV2Client.CreateVectordbAliasesAlter.g.cs
#nullable enable

namespace G
{
    public partial interface IAliasOperationsV2Client
    {
        /// <summary>
        /// Alter Alias<br/>
        /// This operation reassigns the alias of one collection to another.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="authorization"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateVectordbAliasesAlterAsync(
            int? requestTimeout = default,
            string? authorization = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}