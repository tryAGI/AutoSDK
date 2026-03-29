//HintName: G.IAliasOperationsV2Client.CreateVectordbAliasesCreate.g.cs
#nullable enable

namespace G
{
    public partial interface IAliasOperationsV2Client
    {
        /// <summary>
        /// Create Alias<br/>
        /// This operation creates an alias for an existing collection.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="authorization"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateVectordbAliasesCreateAsync(
            int? requestTimeout = default,
            string? authorization = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}