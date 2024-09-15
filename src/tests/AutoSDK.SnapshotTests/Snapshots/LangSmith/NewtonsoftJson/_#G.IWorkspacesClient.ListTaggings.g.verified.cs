//HintName: G.IWorkspacesClient.ListTaggings.g.cs
#nullable enable

namespace G
{
    public partial interface IWorkspacesClient
    {
        /// <summary>
        /// List Taggings
        /// </summary>
        /// <param name="tagValueId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.TaggingsResponse>> ListTaggingsAsync(
            global::G.AnyOf<global::System.Guid?, object>? tagValueId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}