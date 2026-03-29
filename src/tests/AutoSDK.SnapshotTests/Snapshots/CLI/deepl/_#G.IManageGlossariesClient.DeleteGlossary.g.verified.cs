//HintName: G.IManageGlossariesClient.DeleteGlossary.g.cs
#nullable enable

namespace G
{
    public partial interface IManageGlossariesClient
    {
        /// <summary>
        /// Delete a Glossary<br/>
        /// Deletes the specified glossary.
        /// </summary>
        /// <param name="glossaryId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteGlossaryAsync(
            string glossaryId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}