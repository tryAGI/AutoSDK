//HintName: G.IMlClient.List.g.cs
#nullable enable

namespace G
{
    public partial interface IMlClient
    {
        /// <summary>
        /// List ML backends<br/>
        ///     List all configured ML backends for a specific project by ID.<br/>
        ///     Use the following cURL command:<br/>
        ///     ```bash<br/>
        ///     curl http://localhost:8000/api/ml?project={project_id} -H 'Authorization: Token abc123'<br/>
        ///     
        /// </summary>
        /// <param name="project"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.MLBackend>> ListAsync(
            int? project = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}