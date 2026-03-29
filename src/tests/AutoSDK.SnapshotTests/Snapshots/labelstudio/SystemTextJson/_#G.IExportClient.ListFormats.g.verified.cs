//HintName: G.IExportClient.ListFormats.g.cs
#nullable enable

namespace G
{
    public partial interface IExportClient
    {
        /// <summary>
        /// [Deprecated] Get export formats<br/>
        ///         This endpoint is deprecated in Enterprise. Use the async export API instead:<br/>
        ///         POST /api/projects/{{id}}/exports/ (see [Create new export](/api#operation/api_projects_exports_create)).<br/>
        ///         In Label Studio Enterprise, this endpoint will always return a 404 Not Found response with instructions to use the async export API.<br/>
        ///         Retrieve the available export formats for the current project by ID.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<string>> ListFormatsAsync(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}