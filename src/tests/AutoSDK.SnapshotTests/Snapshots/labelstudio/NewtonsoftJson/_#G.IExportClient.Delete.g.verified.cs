//HintName: G.IExportClient.Delete.g.cs
#nullable enable

namespace G
{
    public partial interface IExportClient
    {
        /// <summary>
        /// Delete export snapshot<br/>
        /// Delete an export file by specified export ID.
        /// </summary>
        /// <param name="exportPk"></param>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAsync(
            int exportPk,
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}