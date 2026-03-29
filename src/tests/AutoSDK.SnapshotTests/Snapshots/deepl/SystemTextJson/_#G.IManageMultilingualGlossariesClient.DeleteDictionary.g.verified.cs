//HintName: G.IManageMultilingualGlossariesClient.DeleteDictionary.g.cs
#nullable enable

namespace G
{
    public partial interface IManageMultilingualGlossariesClient
    {
        /// <summary>
        /// Deletes the dictionary associated with the given language pair with the given glossary ID.
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteDictionaryAsync(
            string glossaryId,
            global::G.GlossarySourceLanguage sourceLang,
            global::G.GlossaryTargetLanguage targetLang,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}