//HintName: G.ITasks2Client.CreateManyStatus.g.cs
#nullable enable

namespace G
{
    public partial interface ITasks2Client
    {
        /// <summary>
        /// Get project import status <br/>
        ///             Poll the status of an asynchronous project import operation.<br/>
        ///             <br/>
        ///             **Usage:**<br/>
        ///             1. When you POST to `/api/projects/{project_id}/import`, you'll receive a response like `{"import": &lt;import_id&gt;}`<br/>
        ///             2. Use that `import_id` with this GET endpoint to check the import status<br/>
        ///             3. Poll this endpoint to see if the import has completed, is still processing, or has failed<br/>
        ///             4. **Import errors and failures will only be visible in this GET response**, not in the original POST request<br/>
        ///             <br/>
        ///             This endpoint returns detailed information about the import including task counts, status, and any error messages.<br/>
        ///         
        /// </summary>
        /// <param name="id"></param>
        /// <param name="importPk"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProjectImport> CreateManyStatusAsync(
            int id,
            int importPk,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}