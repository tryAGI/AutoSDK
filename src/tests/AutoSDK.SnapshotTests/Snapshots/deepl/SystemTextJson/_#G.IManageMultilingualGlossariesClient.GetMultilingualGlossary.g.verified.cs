//HintName: G.IManageMultilingualGlossariesClient.GetMultilingualGlossary.g.cs
#nullable enable

namespace G
{
    public partial interface IManageMultilingualGlossariesClient
    {
        /// <summary>
        /// Retrieve Glossary Details<br/>
        /// Retrieve meta information for a single glossary, omitting the glossary entries.
        /// </summary>
        /// <param name="glossaryId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.MultilingualGlossary> GetMultilingualGlossaryAsync(
            string glossaryId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}