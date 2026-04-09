//HintName: G.IAliasOperationsV2Client.CreateVectordbAliasesDrop.g.cs
#nullable enable

namespace G
{
    public partial interface IAliasOperationsV2Client
    {
        /// <summary>
        /// Drop Alias<br/>
        /// This operation drops a specified alias. 
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="authorization"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateVectordbAliasesDropAsync(

            global::G.AliasName request,
            int? requestTimeout = default,
            string? authorization = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Drop Alias<br/>
        /// This operation drops a specified alias. 
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="authorization"></param>
        /// <param name="dbName">
        /// The name of the database to which the collection belongs.
        /// </param>
        /// <param name="collectionName">
        /// The name of the collection to which the alias is assigned to.
        /// </param>
        /// <param name="aliasName1">
        /// The alias to drop.<br/>
        /// When dropping an alias, you do not need to provide the collection name because one alias can only be assigned to exactly one collection. Therefore, the server knows which collection the specified alias belongs to.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateVectordbAliasesDropAsync(
            string collectionName,
            string aliasName1,
            int? requestTimeout = default,
            string? authorization = default,
            string? dbName = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}