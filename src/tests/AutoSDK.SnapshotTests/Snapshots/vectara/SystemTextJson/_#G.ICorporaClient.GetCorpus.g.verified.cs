//HintName: G.ICorporaClient.GetCorpus.g.cs
#nullable enable

namespace G
{
    public partial interface ICorporaClient
    {
        /// <summary>
        /// Retrieve metadata about a corpus<br/>
        /// Get metadata about a corpus. This operation is not a method of searching a corpus.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="corpusKey">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Corpus> GetCorpusAsync(
            string corpusKey,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}