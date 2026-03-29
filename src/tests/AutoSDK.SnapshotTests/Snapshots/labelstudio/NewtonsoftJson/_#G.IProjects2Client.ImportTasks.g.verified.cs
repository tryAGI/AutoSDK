//HintName: G.IProjects2Client.ImportTasks.g.cs
#nullable enable

namespace G
{
    public partial interface IProjects2Client
    {
        /// <summary>
        /// Import tasks<br/>
        ///             Import data as labeling tasks in bulk using this API endpoint. You can use this API endpoint to import multiple tasks.<br/>
        ///             One POST request is limited at 250K tasks and 200 MB.<br/>
        ///             **Note:** Imported data is verified against a project *label_config* and must<br/>
        ///             include all variables that were used in the *label_config*. For example,<br/>
        ///             if the label configuration has a *$text* variable, then each item in a data object<br/>
        ///             must include a "text" field.<br/>
        ///             <br/>
        ///             ## Async Import Behavior<br/>
        ///             &lt;hr style="opacity:0.3"&gt;<br/>
        ///             **For non-Community editions, this endpoint processes imports asynchronously.**<br/>
        ///             <br/>
        ///             - The POST request **can fail** for invalid parameters, malformed request body, or other request-level validation errors.<br/>
        ///             - However, **data validation errors** that occur during import processing are handled asynchronously and will not cause the POST request to fail.<br/>
        ///             - Upon successful request validation, a response is returned: `{"import": &lt;import_id&gt;}`<br/>
        ///             - Use the returned `import_id` to poll the GET `/api/projects/{project_id}/imports/{import_id}` endpoint to check the import status and see any data validation errors.<br/>
        ///             - Data-level errors and import failures will only be visible in the GET request response.<br/>
        ///             For Community edition, imports are processed synchronously and return task counts immediately.<br/>
        ///             <br/>
        ///             ## POST requests<br/>
        ///             &lt;hr style="opacity:0.3"&gt;<br/>
        ///             There are three possible ways to import tasks with this endpoint:<br/>
        ///             ### 1. **POST with data**<br/>
        ///             Send JSON tasks as POST data. Only JSON is supported for POSTing files directly.<br/>
        ///             Update this example to specify your authorization token and Label Studio instance host, then run the following from<br/>
        ///             the command line.<br/>
        ///             ```bash<br/>
        ///             curl -H 'Content-Type: application/json' -H 'Authorization: Token abc123' \<br/>
        ///             -X POST 'http://localhost:8000/api/projects/1/import' --data '[{"text": "Some text 1"}, {"text": "Some text 2"}]'<br/>
        ///             ```<br/>
        ///             ### 2. **POST with files**<br/>
        ///             Send tasks as files. You can attach multiple files with different names.<br/>
        ///             - **JSON**: text files in JavaScript object notation format<br/>
        ///             - **CSV**: text files with tables in Comma Separated Values format<br/>
        ///             - **TSV**: text files with tables in Tab Separated Value format<br/>
        ///             - **TXT**: simple text files are similar to CSV with one column and no header, supported for projects with one source only<br/>
        ///             Update this example to specify your authorization token, Label Studio instance host, and file name and path,<br/>
        ///             then run the following from the command line:<br/>
        ///             ```bash<br/>
        ///             curl -H 'Authorization: Token abc123' \<br/>
        ///             -X POST 'http://localhost:8000/api/projects/1/import' -F 'file=@path/to/my_file.csv'<br/>
        ///             ```<br/>
        ///             ### 3. **POST with URL**<br/>
        ///             You can also provide a URL to a file with labeling tasks. Supported file formats are the same as in option 2.<br/>
        ///             ```bash<br/>
        ///             curl -H 'Content-Type: application/json' -H 'Authorization: Token abc123' \<br/>
        ///             -X POST 'http://localhost:8000/api/projects/1/import' \<br/>
        ///             --data '[{"url": "http://example.com/test1.csv"}, {"url": "http://example.com/test2.csv"}]'<br/>
        ///             ```<br/>
        ///             <br/>
        ///         
        /// </summary>
        /// <param name="commitToProject">
        /// Default Value: true
        /// </param>
        /// <param name="id"></param>
        /// <param name="preannotatedFromFields"></param>
        /// <param name="returnTaskIds">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ApiProjectsImportCreateResponse> ImportTasksAsync(
            int id,

            global::System.Collections.Generic.IList<global::G.ImportApiRequest> request,
            bool? commitToProject = default,
            global::System.Collections.Generic.IList<string>? preannotatedFromFields = default,
            bool? returnTaskIds = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}