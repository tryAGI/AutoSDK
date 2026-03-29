//HintName: G.IExportClient.Get.g.cs
#nullable enable

namespace G
{
    public partial interface IExportClient
    {
        /// <summary>
        /// Get export snapshot by ID<br/>
        /// Retrieve information about an export file by export ID for a specific project.
        /// </summary>
        /// <param name="exportPk"></param>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Export> GetAsync(
            int exportPk,
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}