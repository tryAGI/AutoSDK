//HintName: G.IImportClient.Delete.g.cs
#nullable enable

namespace G
{
    public partial interface IImportClient
    {
        /// <summary>
        /// Delete file upload<br/>
        /// Delete a specific uploaded file.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAsync(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}