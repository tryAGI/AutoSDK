//HintName: G.IMlClient.Update.g.cs
#nullable enable

namespace G
{
    public partial interface IMlClient
    {
        /// <summary>
        /// Update ML Backend<br/>
        ///     Update ML backend parameters using the Label Studio UI or by sending a PATCH request using the following cURL command:<br/>
        ///     ```bash<br/>
        ///     curl -X PATCH -H 'Content-type: application/json' http://localhost:8000/api/ml/{ml_backend_ID} -H 'Authorization: Token abc123'\<br/>
        ///     --data '{"url": "http://localhost:9091"}' <br/>
        ///     
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.MLBackend> UpdateAsync(
            int id,

            global::G.ApiMlPartialUpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update ML Backend<br/>
        ///     Update ML backend parameters using the Label Studio UI or by sending a PATCH request using the following cURL command:<br/>
        ///     ```bash<br/>
        ///     curl -X PATCH -H 'Content-type: application/json' http://localhost:8000/api/ml/{ml_backend_ID} -H 'Authorization: Token abc123'\<br/>
        ///     --data '{"url": "http://localhost:9091"}' <br/>
        ///     
        /// </summary>
        /// <param name="id"></param>
        /// <param name="authMethod">
        /// Auth method
        /// </param>
        /// <param name="basicAuthPass">
        /// Basic auth password
        /// </param>
        /// <param name="basicAuthUser">
        /// Basic auth user
        /// </param>
        /// <param name="description">
        /// Description
        /// </param>
        /// <param name="extraParams">
        /// Extra parameters
        /// </param>
        /// <param name="isInteractive">
        /// Is interactive
        /// </param>
        /// <param name="project">
        /// Project ID
        /// </param>
        /// <param name="timeout">
        /// Response model timeout
        /// </param>
        /// <param name="title">
        /// Title
        /// </param>
        /// <param name="url">
        /// ML backend URL
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.MLBackend> UpdateAsync(
            int id,
            global::G.ApiMlPartialUpdateRequestAuthMethod? authMethod = default,
            string? basicAuthPass = default,
            string? basicAuthUser = default,
            string? description = default,
            object? extraParams = default,
            bool? isInteractive = default,
            int? project = default,
            int? timeout = default,
            string? title = default,
            string? url = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}