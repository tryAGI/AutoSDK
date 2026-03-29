//HintName: G.IApi.CorporaCreate.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Creates an empty `Corpus`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Corpus> CorporaCreateAsync(

            global::G.Corpus request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates an empty `Corpus`.
        /// </summary>
        /// <param name="displayName">
        /// Optional. The human-readable display name for the `Corpus`. The display name must be no more than 512 characters in length, including spaces. Example: "Docs on Semantic Retriever"
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Corpus> CorporaCreateAsync(
            string? displayName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}