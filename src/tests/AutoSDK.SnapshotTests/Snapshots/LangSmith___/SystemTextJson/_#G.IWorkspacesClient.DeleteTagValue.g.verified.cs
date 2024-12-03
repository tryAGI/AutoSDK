//HintName: G.IWorkspacesClient.DeleteTagValue.g.cs
#nullable enable

namespace G
{
    public partial interface IWorkspacesClient
    {
        /// <summary>
        /// Delete Tag Value
        /// </summary>
        /// <param name="tagKeyId"></param>
        /// <param name="tagValueId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteTagValueAsync(
            global::System.Guid tagKeyId,
            global::System.Guid tagValueId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}