//HintName: G.IManageGlossariesClient.ListGlossaries.g.cs
#nullable enable

namespace G
{
    public partial interface IManageGlossariesClient
    {
        /// <summary>
        /// List all Glossaries<br/>
        /// List all glossaries and their meta-information, but not the glossary entries.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListGlossariesResponse> ListGlossariesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List all Glossaries<br/>
        /// List all glossaries and their meta-information, but not the glossary entries.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse<global::G.ListGlossariesResponse>> ListGlossariesAsResponseAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}