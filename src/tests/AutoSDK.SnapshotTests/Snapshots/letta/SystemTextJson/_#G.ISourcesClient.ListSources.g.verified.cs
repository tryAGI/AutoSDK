//HintName: G.ISourcesClient.ListSources.g.cs
#nullable enable

namespace G
{
    public partial interface ISourcesClient
    {
        /// <summary>
        /// List Sources<br/>
        /// List all data sources created by a user.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Source2>> ListSourcesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}