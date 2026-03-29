//HintName: G.IKgApiClient.UpdateGraph.g.cs
#nullable enable

namespace G
{
    public partial interface IKgApiClient
    {
        /// <summary>
        /// Update graph<br/>
        /// Update the name and description of a Knowledge Graph.
        /// </summary>
        /// <param name="graphId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// curl --location --request PUT https://api.writer.com/v1/graphs/{graph_id} \<br/>
        ///  --header "Authorization: Bearer &lt;token&gt;" \<br/>
        ///  --header "Content-Type: application/json" \<br/>
        /// --data-raw '{"name":"string", "description":"string", "urls":[{"url":"https://example.com/docs", "type":"sub_pages", "exclude_urls":["https://example.com/docs/private"]}]}'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::G.GraphResponse> UpdateGraphAsync(
            global::System.Guid graphId,

            global::G.UpdateGraphRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update graph<br/>
        /// Update the name and description of a Knowledge Graph.
        /// </summary>
        /// <param name="graphId"></param>
        /// <param name="name">
        /// The name of the Knowledge Graph (max 255 characters). Omitting this field leaves the name unchanged.
        /// </param>
        /// <param name="description">
        /// A description of the Knowledge Graph (max 255 characters). Omitting this field leaves the description unchanged.
        /// </param>
        /// <param name="urls">
        /// An array of web connector URLs to update for this Knowledge Graph. You can only connect URLs to Knowledge Graphs with the type `web`. To clear the list of URLs, set this field to an empty array.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GraphResponse> UpdateGraphAsync(
            global::System.Guid graphId,
            string? name = default,
            string? description = default,
            global::System.Collections.Generic.IList<global::G.UpdateGraphWebUrl>? urls = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}