//HintName: G.IWorkspacesClient.ListTagsForResources.g.cs
#nullable enable

namespace G
{
    public partial interface IWorkspacesClient
    {
        /// <summary>
        /// List Tags For Resources
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::G.TagKeyWithValuesAndTaggings>>> ListTagsForResourcesAsync(
            global::System.Collections.Generic.IList<global::G.ListTagsForResourceRequest> request,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}