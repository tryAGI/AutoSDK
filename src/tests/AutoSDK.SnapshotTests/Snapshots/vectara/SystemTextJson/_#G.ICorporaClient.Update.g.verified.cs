//HintName: G.ICorporaClient.Update.g.cs
#nullable enable

namespace G
{
    public partial interface ICorporaClient
    {
        /// <summary>
        /// Update a corpus<br/>
        /// The Update Corpus API lets you enable, disable, or update the name and description of a corpus. This is useful to manage the availability of data within the system, such as when you need to take the corpus offline without having to delete the corpus.<br/>
        /// This lets you utilize automated scripts to programmatically control the availability of corpora based on certain conditions. For example, quickly disable a corpus for maintenance updates or in response to security incidents.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="corpusKey">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Corpus> UpdateAsync(
            string corpusKey,

            global::G.UpdateCorpusRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a corpus<br/>
        /// The Update Corpus API lets you enable, disable, or update the name and description of a corpus. This is useful to manage the availability of data within the system, such as when you need to take the corpus offline without having to delete the corpus.<br/>
        /// This lets you utilize automated scripts to programmatically control the availability of corpora based on certain conditions. For example, quickly disable a corpus for maintenance updates or in response to security incidents.
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
        /// Example: new-corpus-name
        /// </param>
        /// <param name="description">
        /// Description of the corpus. If unset or null, then the corpus will remain in the same state.<br/>
        /// Example: New description of the corpus.
        /// </param>
        /// <param name="saveHistory">
        /// Indicates whether to save corpus queries to query history by default.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Corpus> UpdateAsync(
            string corpusKey,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            bool? enabled = default,
            string? name = default,
            string? description = default,
            bool? saveHistory = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}