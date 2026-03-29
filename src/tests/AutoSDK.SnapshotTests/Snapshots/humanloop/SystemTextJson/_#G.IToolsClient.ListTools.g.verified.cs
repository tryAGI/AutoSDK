//HintName: G.IToolsClient.ListTools.g.cs
#nullable enable

namespace G
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// List Tools
        /// </summary>
        /// <param name="page"></param>
        /// <param name="size"></param>
        /// <param name="name"></param>
        /// <param name="sortBy"></param>
        /// <param name="order"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PaginatedToolResponse> ListToolsAsync(
            int? page = default,
            int? size = default,
            string? name = default,
            string? sortBy = default,
            global::G.ListToolsOrder? order = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}