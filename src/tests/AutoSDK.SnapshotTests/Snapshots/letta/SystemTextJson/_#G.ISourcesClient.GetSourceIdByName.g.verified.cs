//HintName: G.ISourcesClient.GetSourceIdByName.g.cs
#nullable enable

namespace G
{
    public partial interface ISourcesClient
    {
        /// <summary>
        /// Get Source Id By Name<br/>
        /// Get a source by name
        /// </summary>
        /// <param name="sourceName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<string> GetSourceIdByNameAsync(
            string sourceName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}