//HintName: G.ISourcesClient.CountSources.g.cs
#nullable enable

namespace G
{
    public partial interface ISourcesClient
    {
        /// <summary>
        /// Count Sources<br/>
        /// Count all data sources created by a user.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<int> CountSourcesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}