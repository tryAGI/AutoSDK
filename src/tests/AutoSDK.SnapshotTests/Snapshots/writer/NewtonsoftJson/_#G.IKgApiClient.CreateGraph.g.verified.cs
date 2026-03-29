//HintName: G.IKgApiClient.CreateGraph.g.cs
#nullable enable

namespace G
{
    public partial interface IKgApiClient
    {
        /// <summary>
        /// Create graph<br/>
        /// Create a new Knowledge Graph.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// curl --location --request POST https://api.writer.com/v1/graphs \<br/>
        ///  --header "Authorization: Bearer &lt;token&gt;" \<br/>
        ///  --header "Content-Type: application/json" \<br/>
        /// --data-raw '{"name":"string"}'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::G.GraphResponse> CreateGraphAsync(

            global::G.GraphRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create graph<br/>
        /// Create a new Knowledge Graph.
        /// </summary>
        /// <param name="name">
        /// The name of the Knowledge Graph (max 255 characters). Omitting this field leaves the name unchanged.
        /// </param>
        /// <param name="description">
        /// A description of the Knowledge Graph (max 255 characters). Omitting this field leaves the description unchanged.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GraphResponse> CreateGraphAsync(
            string? name = default,
            string? description = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}