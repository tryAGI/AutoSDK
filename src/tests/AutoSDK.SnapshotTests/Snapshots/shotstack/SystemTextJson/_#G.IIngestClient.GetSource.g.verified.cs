//HintName: G.IIngestClient.GetSource.g.cs
#nullable enable

namespace G
{
    public partial interface IIngestClient
    {
        /// <summary>
        /// Get Source<br/>
        /// Fetch a source file details and status by its id.<br/>
        /// **Base URL:** &lt;a href="#"&gt;https://api.shotstack.io/ingest/{version}&lt;/a&gt;
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.SourceResponse> GetSourceAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}