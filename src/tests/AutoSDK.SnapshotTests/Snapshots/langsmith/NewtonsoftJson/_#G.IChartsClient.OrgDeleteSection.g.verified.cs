//HintName: G.IChartsClient.OrgDeleteSection.g.cs
#nullable enable

namespace G
{
    public partial interface IChartsClient
    {
        /// <summary>
        /// Org Delete Section<br/>
        /// Delete a section.
        /// </summary>
        /// <param name="sectionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> OrgDeleteSectionAsync(
            global::System.Guid sectionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}