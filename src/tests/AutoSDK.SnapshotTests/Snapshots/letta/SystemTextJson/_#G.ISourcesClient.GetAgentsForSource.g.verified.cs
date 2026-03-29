//HintName: G.ISourcesClient.GetAgentsForSource.g.cs
#nullable enable

namespace G
{
    public partial interface ISourcesClient
    {
        /// <summary>
        /// Get Agents For Source<br/>
        /// Get all agent IDs that have the specified source attached.
        /// </summary>
        /// <param name="sourceId">
        /// The ID of the source in the format 'source-&lt;uuid4&gt;'
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<string>> GetAgentsForSourceAsync(
            string sourceId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}