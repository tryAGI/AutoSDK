//HintName: G.IManageGlossariesClient.ListGlossaryLanguages.g.cs
#nullable enable

namespace G
{
    public partial interface IManageGlossariesClient
    {
        /// <summary>
        /// List Language Pairs Supported by Glossaries<br/>
        /// Retrieve the list of language pairs supported by the glossary feature.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListGlossaryLanguagesResponse> ListGlossaryLanguagesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Language Pairs Supported by Glossaries<br/>
        /// Retrieve the list of language pairs supported by the glossary feature.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse<global::G.ListGlossaryLanguagesResponse>> ListGlossaryLanguagesAsResponseAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}