//HintName: G.IExportClient.Convert.g.cs
#nullable enable

namespace G
{
    public partial interface IExportClient
    {
        /// <summary>
        /// Export conversion<br/>
        /// Convert export snapshot to selected format
        /// </summary>
        /// <param name="exportPk"></param>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ApiProjectsExportsConvertCreateResponse> ConvertAsync(
            int exportPk,
            int id,

            global::G.ExportConvertRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Export conversion<br/>
        /// Convert export snapshot to selected format
        /// </summary>
        /// <param name="exportPk"></param>
        /// <param name="id"></param>
        /// <param name="downloadResources">
        /// Download resources in converter.
        /// </param>
        /// <param name="exportType">
        /// Export file format.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ApiProjectsExportsConvertCreateResponse> ConvertAsync(
            int exportPk,
            int id,
            string exportType,
            bool? downloadResources = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}