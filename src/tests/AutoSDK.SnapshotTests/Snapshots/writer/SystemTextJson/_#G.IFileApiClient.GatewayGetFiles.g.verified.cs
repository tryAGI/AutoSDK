//HintName: G.IFileApiClient.GatewayGetFiles.g.cs
#nullable enable

namespace G
{
    public partial interface IFileApiClient
    {
        /// <summary>
        /// List files<br/>
        /// Retrieve a paginated list of files with optional filtering by status, graph association, and file type.
        /// </summary>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="order">
        /// Default Value: desc
        /// </param>
        /// <param name="graphId"></param>
        /// <param name="status"></param>
        /// <param name="fileTypes"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// curl --location --request GET https://api.writer.com/v1/files \<br/>
        ///  --header "Authorization: Bearer &lt;token&gt;"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::G.FilesResponse> GatewayGetFilesAsync(
            string? before = default,
            string? after = default,
            int? limit = default,
            global::G.GatewayGetFilesOrder? order = default,
            global::System.Guid? graphId = default,
            global::G.GatewayGetFilesStatus? status = default,
            string? fileTypes = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}