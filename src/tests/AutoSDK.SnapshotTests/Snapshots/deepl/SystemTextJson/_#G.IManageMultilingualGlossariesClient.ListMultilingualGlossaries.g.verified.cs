//HintName: G.IManageMultilingualGlossariesClient.ListMultilingualGlossaries.g.cs
#nullable enable

namespace G
{
    public partial interface IManageMultilingualGlossariesClient
    {
        /// <summary>
        /// List all Glossaries<br/>
        /// List all glossaries and their meta-information, but not the glossary entries.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListMultilingualGlossariesResponse> ListMultilingualGlossariesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List all Glossaries<br/>
        /// List all glossaries and their meta-information, but not the glossary entries.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse<global::G.ListMultilingualGlossariesResponse>> ListMultilingualGlossariesAsResponseAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}