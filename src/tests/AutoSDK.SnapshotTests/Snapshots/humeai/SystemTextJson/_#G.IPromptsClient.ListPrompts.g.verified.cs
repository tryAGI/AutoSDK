//HintName: G.IPromptsClient.ListPrompts.g.cs
#nullable enable

namespace G
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// List EVI prompts
        /// </summary>
        /// <param name="pageNumber"></param>
        /// <param name="pageSize"></param>
        /// <param name="restrictToMostRecent"></param>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ReturnPagedPrompts> ListPromptsAsync(
            int? pageNumber = default,
            int? pageSize = default,
            bool? restrictToMostRecent = default,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}