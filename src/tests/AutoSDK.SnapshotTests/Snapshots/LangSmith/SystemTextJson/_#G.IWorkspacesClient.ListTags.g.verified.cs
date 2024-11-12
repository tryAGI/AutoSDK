//HintName: G.IWorkspacesClient.ListTags.g.cs
#nullable enable

namespace G
{
    public partial interface IWorkspacesClient
    {
        /// <summary>
        /// List Tags
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.TagKeyWithValues>> ListTagsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}