//HintName: G.IWorkspacesClient.GetTagValue.g.cs
#nullable enable

namespace G
{
    public partial interface IWorkspacesClient
    {
        /// <summary>
        /// Get Tag Value
        /// </summary>
        /// <param name="tagKeyId"></param>
        /// <param name="tagValueId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TagValue> GetTagValueAsync(
            global::System.Guid tagKeyId,
            global::System.Guid tagValueId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}