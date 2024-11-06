//HintName: G.IRAGEngineClient.V1LibraryManagement.g.cs
#nullable enable

namespace G
{
    public partial interface IRAGEngineClient
    {
        /// <summary>
        /// Generate Documents Signed Url
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="requestStartTime">
        /// Default Value: 1730898830008
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> V1LibraryManagementAsync(
            global::System.Guid fileId,
            int? requestStartTime = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}