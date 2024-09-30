//HintName: G.IEncodersClient.ListEncoders.g.cs
#nullable enable

namespace G
{
    public partial interface IEncodersClient
    {
        /// <summary>
        /// List encoders<br/>
        /// Encoders are used to store and retrieve from a corpus.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="filter">
        /// Example: vectara.*
        /// </param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="pageKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListEncodersResponse> ListEncodersAsync(
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? filter = default,
            int? limit = 10,
            string? pageKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}