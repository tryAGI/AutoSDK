//HintName: G.IApi.GetWorkflowSchemaWorkflowsDefinitionSchemaGet.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Endpoint to fetch the workflows block schema<br/>
        /// Endpoint to fetch the schema of all available blocks. This information can be used to validate workflow definitions and suggest syntax in the JSON editor.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.WorkflowsBlocksSchemaDescription> GetWorkflowSchemaWorkflowsDefinitionSchemaGetAsync(
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}