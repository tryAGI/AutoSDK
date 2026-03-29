//HintName: G.IToolsClient.GetTools.g.cs
#nullable enable

namespace G
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// List available tools<br/>
        /// Retrieve a paginated list of available tools with comprehensive filtering, sorting and search capabilities. Use query parameters to narrow down results by toolkit, tags, or search terms.
        /// </summary>
        /// <param name="toolkitSlug"></param>
        /// <param name="toolSlugs"></param>
        /// <param name="authConfigIds"></param>
        /// <param name="important"></param>
        /// <param name="tags"></param>
        /// <param name="scopes">
        /// Filter tools by one or more scopes (can be specified multiple times)
        /// </param>
        /// <param name="query"></param>
        /// <param name="search"></param>
        /// <param name="includeDeprecated">
        /// Default Value: true
        /// </param>
        /// <param name="toolkitVersions"></param>
        /// <param name="limit"></param>
        /// <param name="cursor"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ToolsPaginated> GetToolsAsync(
            string? toolkitSlug = default,
            string? toolSlugs = default,
            global::G.OneOf<string, global::System.Collections.Generic.IList<string>>? authConfigIds = default,
            global::G.GetToolsImportant? important = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::System.Collections.Generic.IList<string>? scopes = default,
            string? query = default,
            string? search = default,
            bool? includeDeprecated = default,
            global::G.OneOf<object, string, global::System.Collections.Generic.Dictionary<string, string>>? toolkitVersions = default,
            double? limit = default,
            string? cursor = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}