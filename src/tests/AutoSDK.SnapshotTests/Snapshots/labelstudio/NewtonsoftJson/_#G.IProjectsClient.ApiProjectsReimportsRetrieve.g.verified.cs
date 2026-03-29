//HintName: G.IProjectsClient.ApiProjectsReimportsRetrieve.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Get project reimport status<br/>
        ///             Poll the status of an asynchronous project reimport operation.<br/>
        ///             <br/>
        ///             **Usage:**<br/>
        ///             1. When you POST to reimport tasks, you'll receive a response with a reimport ID<br/>
        ///             2. Use that `reimport_id` with this GET endpoint to check the reimport status<br/>
        ///             3. Poll this endpoint to see if the reimport has completed, is still processing, or has failed<br/>
        ///             4. **Reimport errors and failures will only be visible in this GET response**, not in the original POST request<br/>
        ///             <br/>
        ///             This endpoint returns detailed information about the reimport including task counts, status, and any error messages.<br/>
        ///         
        /// </summary>
        /// <param name="id"></param>
        /// <param name="reimportPk"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProjectReimport> ApiProjectsReimportsRetrieveAsync(
            int id,
            int reimportPk,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}