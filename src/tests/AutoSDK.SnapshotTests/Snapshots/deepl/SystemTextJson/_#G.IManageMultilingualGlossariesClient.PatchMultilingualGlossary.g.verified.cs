//HintName: G.IManageMultilingualGlossariesClient.PatchMultilingualGlossary.g.cs
#nullable enable

namespace G
{
    public partial interface IManageMultilingualGlossariesClient
    {
        /// <summary>
        /// Edit glossary details<br/>
        /// Edit glossary details, such as name or a dictionary for a source and target language.
        /// </summary>
        /// <param name="glossaryId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.MultilingualGlossary> PatchMultilingualGlossaryAsync(
            string glossaryId,

            global::G.PatchMultilingualGlossaryParameters request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Edit glossary details<br/>
        /// Edit glossary details, such as name or a dictionary for a source and target language.
        /// </summary>
        /// <param name="glossaryId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse<global::G.MultilingualGlossary>> PatchMultilingualGlossaryAsResponseAsync(
            string glossaryId,

            global::G.PatchMultilingualGlossaryParameters request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Edit glossary details<br/>
        /// Edit glossary details, such as name or a dictionary for a source and target language.
        /// </summary>
        /// <param name="glossaryId"></param>
        /// <param name="name">
        /// A unique ID assigned to a glossary.<br/>
        /// Example: def3a26b-3e84-45b3-84ae-0c0aaf3525f7
        /// </param>
        /// <param name="dictionaries">
        /// Dictionaries to edit the glossary with. Currently only supports 0 or 1 dictionaries in the array.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.MultilingualGlossary> PatchMultilingualGlossaryAsync(
            string glossaryId,
            string? name = default,
            global::System.Collections.Generic.IList<global::G.GlossaryDictionary>? dictionaries = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}