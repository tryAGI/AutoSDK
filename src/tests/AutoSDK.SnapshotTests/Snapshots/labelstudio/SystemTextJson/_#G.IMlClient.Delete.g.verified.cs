//HintName: G.IMlClient.Delete.g.cs
#nullable enable

namespace G
{
    public partial interface IMlClient
    {
        /// <summary>
        /// Remove ML Backend<br/>
        ///     Remove an existing ML backend connection by ID. For example, use the<br/>
        ///     following cURL command:<br/>
        ///     ```bash<br/>
        ///     curl -X DELETE http://localhost:8000/api/ml/{ml_backend_ID} -H 'Authorization: Token abc123'<br/>
        ///     
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAsync(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}