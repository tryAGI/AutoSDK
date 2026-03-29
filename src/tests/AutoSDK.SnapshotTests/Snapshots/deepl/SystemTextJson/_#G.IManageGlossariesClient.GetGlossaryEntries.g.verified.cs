//HintName: G.IManageGlossariesClient.GetGlossaryEntries.g.cs
#nullable enable

namespace G
{
    public partial interface IManageGlossariesClient
    {
        /// <summary>
        /// Retrieve Glossary Entries<br/>
        /// List the entries of a single glossary in the format specified by the `Accept` header.
        /// </summary>
        /// <param name="glossaryId"></param>
        /// <param name="accept">
        /// Default Value: text/tab-separated-values
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task GetGlossaryEntriesAsync(
            string glossaryId,
            global::G.GetGlossaryEntriesAccept? accept = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}