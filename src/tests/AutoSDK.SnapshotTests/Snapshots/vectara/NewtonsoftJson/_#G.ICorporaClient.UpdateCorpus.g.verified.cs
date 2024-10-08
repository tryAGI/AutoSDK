//HintName: G.ICorporaClient.UpdateCorpus.g.cs
#nullable enable

namespace G
{
    public partial interface ICorporaClient
    {
        /// <summary>
        /// Update a corpus<br/>
        /// Enable, disable, or update the name and description of a corpus. This lets you<br/>
        /// manage data availability without deleting the corpus, which is useful for <br/>
        /// maintenance and security purposes. The `corpus_key` uniquely identifies the corpus. <br/>
        /// For more information, see [Corpus Key Definition](https://docs.vectara.com/docs/api-reference/search-apis/search#corpus-key-definition). <br/>
        /// Update the name and description of a corpus dynamically to help keep your data <br/>
        /// aligned with changing business needs.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="corpusKey">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Corpus> UpdateCorpusAsync(
            string corpusKey,
            global::G.UpdateCorpusRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update a corpus<br/>
        /// Enable, disable, or update the name and description of a corpus. This lets you<br/>
        /// manage data availability without deleting the corpus, which is useful for <br/>
        /// maintenance and security purposes. The `corpus_key` uniquely identifies the corpus. <br/>
        /// For more information, see [Corpus Key Definition](https://docs.vectara.com/docs/api-reference/search-apis/search#corpus-key-definition). <br/>
        /// Update the name and description of a corpus dynamically to help keep your data <br/>
        /// aligned with changing business needs.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="corpusKey">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>
        /// <param name="enabled">
        /// Set whether or not the corpus is enabled. If unset then the corpus will remain in the same state.<br/>
        /// Example: false
        /// </param>
        /// <param name="name">
        /// The name for the corpus. If unset or null, then the corpus will remain in the same state.<br/>
        /// Example: new-name
        /// </param>
        /// <param name="description">
        /// Description of the corpus. If unset or null, then the corpus will remain in the same state.<br/>
        /// Example: New description of the corpus.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Corpus> UpdateCorpusAsync(
            string corpusKey,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            bool? enabled = default,
            string? name = default,
            string? description = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}