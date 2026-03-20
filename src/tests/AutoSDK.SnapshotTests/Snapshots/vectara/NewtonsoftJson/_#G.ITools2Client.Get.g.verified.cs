//HintName: G.ITools2Client.Get.g.cs
#nullable enable

namespace G
{
    public partial interface ITools2Client
    {
        /// <summary>
        /// Get tool<br/>
        /// Retrieve the full details of a specific tool, including its description, input schema, metadata, and capabilities. Tools may represent structured search functions, document-processing workflows, or user-defined Lambda functions. Some tools work with artifacts stored in a session, while others operate on structured inputs defined by their JSON schema.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="toolId">
        /// Example: tol_rag_search
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Tool> GetAsync(
            string toolId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}