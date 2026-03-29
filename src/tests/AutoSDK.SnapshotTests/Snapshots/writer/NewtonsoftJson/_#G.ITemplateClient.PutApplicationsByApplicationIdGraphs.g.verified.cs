//HintName: G.ITemplateClient.PutApplicationsByApplicationIdGraphs.g.cs
#nullable enable

namespace G
{
    public partial interface ITemplateClient
    {
        /// <summary>
        /// Associate graphs<br/>
        /// Updates the list of Knowledge Graphs associated with a no-code chat agent.
        /// </summary>
        /// <param name="applicationId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// curl --location --request PUT https://api.writer.com/v1/applications/{application_id}/graphs \<br/>
        ///  --header "Authorization: Bearer &lt;token&gt;" \<br/>
        ///  --header "Content-Type: application/json" \<br/>
        /// --data-raw '{"graph_ids":["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e","182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e","182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"]}'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::G.ApplicationGraphsResponse> PutApplicationsByApplicationIdGraphsAsync(
            string applicationId,

            global::G.ApplicationGraphIdsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Associate graphs<br/>
        /// Updates the list of Knowledge Graphs associated with a no-code chat agent.
        /// </summary>
        /// <param name="applicationId"></param>
        /// <param name="graphIds">
        /// A list of Knowledge Graph IDs to associate with the application. Note that this will replace the existing list of Knowledge Graphs associated with the application, not add to it.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ApplicationGraphsResponse> PutApplicationsByApplicationIdGraphsAsync(
            string applicationId,
            global::System.Collections.Generic.IList<global::System.Guid> graphIds,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}