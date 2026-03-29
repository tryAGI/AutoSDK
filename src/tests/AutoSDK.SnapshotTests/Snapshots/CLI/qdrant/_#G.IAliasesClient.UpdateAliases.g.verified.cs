//HintName: G.IAliasesClient.UpdateAliases.g.cs
#nullable enable

namespace G
{
    public partial interface IAliasesClient
    {
        /// <summary>
        /// Update aliases of the collections
        /// </summary>
        /// <param name="timeout"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateAliasesResponse> UpdateAliasesAsync(

            global::G.ChangeAliasesOperation request,
            int? timeout = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update aliases of the collections
        /// </summary>
        /// <param name="timeout"></param>
        /// <param name="actions"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateAliasesResponse> UpdateAliasesAsync(
            global::System.Collections.Generic.IList<global::G.AliasOperations> actions,
            int? timeout = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}