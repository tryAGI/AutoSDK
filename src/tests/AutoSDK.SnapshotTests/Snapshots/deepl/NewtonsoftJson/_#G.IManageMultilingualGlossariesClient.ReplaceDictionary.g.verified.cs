//HintName: G.IManageMultilingualGlossariesClient.ReplaceDictionary.g.cs
#nullable enable

namespace G
{
    public partial interface IManageMultilingualGlossariesClient
    {
        /// <summary>
        /// Replaces or creates a dictionary in the glossary with the specified entries.
        /// </summary>
        /// <param name="glossaryId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.MultilingualGlossaryEntriesInformation> ReplaceDictionaryAsync(
            string glossaryId,

            global::G.MultilingualGlossaryEntries request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Replaces or creates a dictionary in the glossary with the specified entries.
        /// </summary>
        /// <param name="glossaryId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse<global::G.MultilingualGlossaryEntriesInformation>> ReplaceDictionaryAsResponseAsync(
            string glossaryId,

            global::G.MultilingualGlossaryEntries request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Replaces or creates a dictionary in the glossary with the specified entries.
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
        /// <param name="entries">
        /// The entries of the glossary. The entries have to be specified in the format provided by the `entries_format` parameter.<br/>
        /// Example: Hello	Guten Tag
        /// </param>
        /// <param name="entriesFormat">
        /// The format in which the glossary entries are provided. Formats currently available:<br/>
        /// - `tsv` (default) - tab-separated values<br/>
        /// - `csv` - comma-separated values<br/>
        /// See [Supported Glossary Formats](https://www.deepl.com/docs-api/glossaries/formats) for details about each format.<br/>
        /// Default Value: tsv<br/>
        /// Example: tsv
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.MultilingualGlossaryEntriesInformation> ReplaceDictionaryAsync(
            string glossaryId,
            global::G.GlossarySourceLanguage? sourceLang = default,
            global::G.GlossaryTargetLanguage? targetLang = default,
            string? entries = default,
            global::G.GlossaryEntriesFormat? entriesFormat = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}