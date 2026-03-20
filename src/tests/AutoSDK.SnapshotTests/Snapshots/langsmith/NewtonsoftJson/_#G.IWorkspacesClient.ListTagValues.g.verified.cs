//HintName: G.IWorkspacesClient.ListTagValues.g.cs
#nullable enable

namespace G
{
    public partial interface IWorkspacesClient
    {
        /// <summary>
        /// List Tag Values
        /// </summary>
        /// <param name="tagKeyId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.TagValue>> ListTagValuesAsync(
            global::System.Guid tagKeyId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}