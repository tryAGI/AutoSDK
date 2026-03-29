//HintName: G.IKgApiClient.RemoveFileFromGraph.g.cs
#nullable enable

namespace G
{
    public partial interface IKgApiClient
    {
        /// <summary>
        /// Remove file from graph<br/>
        /// Remove a file from a Knowledge Graph.
        /// </summary>
        /// <param name="graphId"></param>
        /// <param name="fileId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// curl --location --request DELETE https://api.writer.com/v1/graphs/{graph_id}/file/{file_id} \<br/>
        ///  --header "Authorization: Bearer &lt;token&gt;"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::G.DeleteFileResponse> RemoveFileFromGraphAsync(
            global::System.Guid graphId,
            string fileId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}