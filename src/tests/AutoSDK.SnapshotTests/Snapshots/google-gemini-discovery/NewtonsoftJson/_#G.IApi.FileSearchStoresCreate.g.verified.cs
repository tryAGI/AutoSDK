//HintName: G.IApi.FileSearchStoresCreate.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Creates an empty `FileSearchStore`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.FileSearchStore> FileSearchStoresCreateAsync(

            global::G.FileSearchStore request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates an empty `FileSearchStore`.
        /// </summary>
        /// <param name="displayName">
        /// Optional. The human-readable display name for the `FileSearchStore`. The display name must be no more than 512 characters in length, including spaces. Example: "Docs on Semantic Retriever"
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.FileSearchStore> FileSearchStoresCreateAsync(
            string? displayName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}