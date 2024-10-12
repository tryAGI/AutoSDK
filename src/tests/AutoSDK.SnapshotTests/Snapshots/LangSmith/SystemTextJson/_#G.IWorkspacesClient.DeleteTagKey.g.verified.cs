//HintName: G.IWorkspacesClient.DeleteTagKey.g.cs
#nullable enable

namespace G
{
    public partial interface IWorkspacesClient
    {
        /// <summary>
        /// Delete Tag Key
        /// </summary>
        /// <param name="tagKeyId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteTagKeyAsync(
            global::System.Guid tagKeyId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}