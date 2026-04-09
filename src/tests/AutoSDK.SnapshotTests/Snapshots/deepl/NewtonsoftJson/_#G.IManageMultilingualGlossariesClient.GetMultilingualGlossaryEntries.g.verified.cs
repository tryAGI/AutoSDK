//HintName: G.IManageMultilingualGlossariesClient.GetMultilingualGlossaryEntries.g.cs
#nullable enable

namespace G
{
    public partial interface IManageMultilingualGlossariesClient
    {
        /// <summary>
        /// Retrieve Glossary Entries<br/>
        /// List the entries of a single glossary in tsv format.
        /// </summary>
        /// <param name="glossaryId"></param>
        /// <param name="sourceLang">
        /// The language in which the source texts in the glossary are specified.<br/>
        /// Example: en
        /// </param>
        /// <param name="targetLang">
        /// The language in which the target texts in the glossary are specified.<br/>
        /// Example: de
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GlossaryDictionary> GetMultilingualGlossaryEntriesAsync(
            string glossaryId,
            global::G.GlossarySourceLanguage sourceLang,
            global::G.GlossaryTargetLanguage targetLang,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve Glossary Entries<br/>
        /// List the entries of a single glossary in tsv format.
        /// </summary>
        /// <param name="glossaryId"></param>
        /// <param name="sourceLang">
        /// The language in which the source texts in the glossary are specified.<br/>
        /// Example: en
        /// </param>
        /// <param name="targetLang">
        /// The language in which the target texts in the glossary are specified.<br/>
        /// Example: de
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse<global::G.GlossaryDictionary>> GetMultilingualGlossaryEntriesAsResponseAsync(
            string glossaryId,
            global::G.GlossarySourceLanguage sourceLang,
            global::G.GlossaryTargetLanguage targetLang,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}