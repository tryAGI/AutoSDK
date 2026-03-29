//HintName: G.IStorageGcsClient.Delete.g.cs
#nullable enable

namespace G
{
    public partial interface IStorageGcsClient
    {
        /// <summary>
        /// Delete export storage<br/>
        /// Delete a specific GCS export storage connection.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAsync(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}