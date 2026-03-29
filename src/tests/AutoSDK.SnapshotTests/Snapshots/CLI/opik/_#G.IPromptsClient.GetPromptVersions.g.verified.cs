//HintName: G.IPromptsClient.GetPromptVersions.g.cs
#nullable enable

namespace G
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Get prompt versions<br/>
        /// Get prompt versions
        /// </summary>
        /// <param name="id"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="size">
        /// Default Value: 10
        /// </param>
        /// <param name="search"></param>
        /// <param name="sorting"></param>
        /// <param name="filters"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PromptVersionPagePublic> GetPromptVersionsAsync(
            global::System.Guid id,
            int? page = default,
            int? size = default,
            string? search = default,
            string? sorting = default,
            string? filters = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}