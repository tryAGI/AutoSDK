//HintName: G.ICorporaClient.ResetCorpus.g.cs
#nullable enable

namespace G
{
    public partial interface ICorporaClient
    {
        /// <summary>
        /// Remove all documents and data in a corpus<br/>
        /// Resets a corpus, which removes all documents and data from the specified corpus, while keeping the corpus itself.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="corpusKey">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Error> ResetCorpusAsync(
            string corpusKey,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}