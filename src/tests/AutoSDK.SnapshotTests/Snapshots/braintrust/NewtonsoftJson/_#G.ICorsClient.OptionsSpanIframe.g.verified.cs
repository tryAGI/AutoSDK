//HintName: G.ICorsClient.OptionsSpanIframe.g.cs
#nullable enable

namespace G
{
    public partial interface ICorsClient
    {
        /// <summary>
        /// Enable CORS (`/v1/span_iframe`)<br/>
        /// Enable CORS
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task OptionsSpanIframeAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}