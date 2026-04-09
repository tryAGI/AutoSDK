//HintName: G.IExportClient.Download.g.cs
#nullable enable

namespace G
{
    public partial interface IExportClient
    {
        /// <summary>
        /// Download export snapshot as file in specified format<br/>
        ///         Download an export file in the specified format for a specific project. Specify the project ID with the `id`<br/>
        ///         parameter in the path and the ID of the export file you want to download using the `export_pk` parameter<br/>
        ///         in the path.<br/>
        ///         Get the `export_pk` from the response of the request to [Create new export](/api#operation/api_projects_exports_create)<br/>
        ///         or after [listing export files](/api#operation/api_projects_exports_list).<br/>
        ///         
        /// </summary>
        /// <param name="exportType"></param>
        /// <param name="exportPk"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> DownloadAsync(
            int exportPk,
            int id,
            string? exportType = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}