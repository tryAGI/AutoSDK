//HintName: G.IMlClient.Create.g.cs
#nullable enable

namespace G
{
    public partial interface IMlClient
    {
        /// <summary>
        /// Add ML Backend<br/>
        ///     Add an ML backend to a project using the Label Studio UI or by sending a POST request using the following cURL <br/>
        ///     command:<br/>
        ///     ```bash<br/>
        ///     curl -X POST -H 'Content-type: application/json' http://localhost:8000/api/ml -H 'Authorization: Token abc123'\<br/>
        ///     --data '{"url": "http://localhost:9090", "project": {project_id}}' <br/>
        ///     
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.MLBackend> CreateAsync(

            global::G.ApiMlCreateRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add ML Backend<br/>
        ///     Add an ML backend to a project using the Label Studio UI or by sending a POST request using the following cURL <br/>
        ///     command:<br/>
        ///     ```bash<br/>
        ///     curl -X POST -H 'Content-type: application/json' http://localhost:8000/api/ml -H 'Authorization: Token abc123'\<br/>
        ///     --data '{"url": "http://localhost:9090", "project": {project_id}}' <br/>
        ///     
        /// </summary>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.MLBackend> CreateAsync(
            global::G.ApiMlCreateRequestAuthMethod? authMethod = default,
            string? basicAuthPass = default,
            string? basicAuthUser = default,
            string? description = default,
            object? extraParams = default,
            bool? isInteractive = default,
            int? project = default,
            int? timeout = default,
            string? title = default,
            string? url = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}