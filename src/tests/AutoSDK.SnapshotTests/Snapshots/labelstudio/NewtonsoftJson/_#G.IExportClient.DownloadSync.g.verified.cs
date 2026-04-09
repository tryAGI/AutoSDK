//HintName: G.IExportClient.DownloadSync.g.cs
#nullable enable

namespace G
{
    public partial interface IExportClient
    {
        /// <summary>
        /// [Deprecated] Easy export of tasks and annotations<br/>
        ///         This endpoint is deprecated in Enterprise. Use the async export API instead:<br/>
        ///         POST /api/projects/{id}/exports/ (see [Create new export](/api#operation/api_projects_exports_create)).<br/>
        ///         In Label Studio Enterprise, this endpoint will always return a 404 Not Found response with instructions to use the async export API.<br/>
        ///         &lt;i&gt;Note: if you have a large project it's recommended to use<br/>
        ///         export snapshots, this easy export endpoint might have timeouts.&lt;/i&gt;&lt;br/&gt;<br/>
        ///         Export annotated tasks as a file in a specific format.<br/>
        ///         For example, to export JSON annotations for a project to a file called `annotations.json`,<br/>
        ///         run the following from the command line:<br/>
        ///         ```bash<br/>
        ///         curl -X GET http://localhost:8000/api/projects/{id}/export?exportType=JSON -H 'Authorization: Token abc123' --output 'annotations.json'<br/>
        ///         ```<br/>
        ///         To export all tasks, including skipped tasks and others without annotations, run the following from the command line:<br/>
        ///         ```bash<br/>
        ///         curl -X GET http://localhost:8000/api/projects/{id}/export?exportType=JSON&amp;download_all_tasks=true -H 'Authorization: Token abc123' --output 'annotations.json'<br/>
        ///         ```<br/>
        ///         To export specific tasks with IDs of 123 and 345, run the following from the command line:<br/>
        ///         ```bash<br/>
        ///         curl -X GET 'http://localhost:8000/api/projects/{id}/export?ids[]=123&amp;ids[]=345' -H 'Authorization: Token abc123' --output 'annotations.json'<br/>
        ///         ```<br/>
        ///         
        /// </summary>
        /// <param name="downloadAllTasks"></param>
        /// <param name="downloadResources"></param>
        /// <param name="exportType"></param>
        /// <param name="id"></param>
        /// <param name="ids"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<byte[]> DownloadSyncAsync(
            int id,
            bool? downloadAllTasks = default,
            bool? downloadResources = default,
            string? exportType = default,
            global::System.Collections.Generic.IList<string>? ids = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}