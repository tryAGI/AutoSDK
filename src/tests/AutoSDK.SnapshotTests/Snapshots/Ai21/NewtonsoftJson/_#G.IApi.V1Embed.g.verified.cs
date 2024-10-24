//HintName: G.IApi.V1Embed.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Embed
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> V1EmbedAsync(
            global::G.EmbeddingsBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Embed
        /// </summary>
        /// <param name="texts"></param>
        /// <param name="type">
        /// Default Value: segment
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> V1EmbedAsync(
            global::System.Collections.Generic.IList<string> texts,
            global::G.EmbedType? type = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}