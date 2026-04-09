//HintName: G.IParsingClient.GetSupportedFileExtensionsApiV1ParsingSupportedFileExtensionsGet.g.cs
#nullable enable

namespace G
{
    public partial interface IParsingClient
    {
        /// <summary>
        /// Get Supported File Extensions<br/>
        /// Get a list of supported file extensions
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.LlamaParseSupportedFileExtensions>> GetSupportedFileExtensionsApiV1ParsingSupportedFileExtensionsGetAsync(
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}