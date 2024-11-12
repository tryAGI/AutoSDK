//HintName: G.IWorkspacesClient.DeleteTagging.g.cs
#nullable enable

namespace G
{
    public partial interface IWorkspacesClient
    {
        /// <summary>
        /// Delete Tagging
        /// </summary>
        /// <param name="taggingId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteTaggingAsync(
            global::System.Guid taggingId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}