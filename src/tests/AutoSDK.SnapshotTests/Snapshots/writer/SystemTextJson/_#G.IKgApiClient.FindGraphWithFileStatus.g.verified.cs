//HintName: G.IKgApiClient.FindGraphWithFileStatus.g.cs
#nullable enable

namespace G
{
    public partial interface IKgApiClient
    {
        /// <summary>
        /// Retrieve graph<br/>
        /// Retrieve a Knowledge Graph.
        /// </summary>
        /// <param name="graphId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// curl --location --request GET https://api.writer.com/v1/graphs/{graph_id} \<br/>
        ///  --header "Authorization: Bearer &lt;token&gt;"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::G.Graph> FindGraphWithFileStatusAsync(
            global::System.Guid graphId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}