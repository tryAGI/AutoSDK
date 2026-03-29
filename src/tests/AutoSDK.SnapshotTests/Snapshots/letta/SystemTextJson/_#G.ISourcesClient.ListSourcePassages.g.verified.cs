//HintName: G.ISourcesClient.ListSourcePassages.g.cs
#nullable enable

namespace G
{
    public partial interface ISourcesClient
    {
        /// <summary>
        /// List Source Passages<br/>
        /// List all passages associated with a data source.
        /// </summary>
        /// <param name="sourceId">
        /// The ID of the source in the format 'source-&lt;uuid4&gt;'
        /// </param>
        /// <param name="after">
        /// Message after which to retrieve the returned messages.
        /// </param>
        /// <param name="before">
        /// Message before which to retrieve the returned messages.
        /// </param>
        /// <param name="limit">
        /// Maximum number of messages to retrieve.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Passage>> ListSourcePassagesAsync(
            string sourceId,
            string? after = default,
            string? before = default,
            int? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}