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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.LlamaParseSupportedFileExtensions>> GetSupportedFileExtensionsApiV1ParsingSupportedFileExtensionsGetAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}