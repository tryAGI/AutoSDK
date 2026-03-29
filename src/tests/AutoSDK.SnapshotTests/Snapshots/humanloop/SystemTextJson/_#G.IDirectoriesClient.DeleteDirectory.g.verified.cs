//HintName: G.IDirectoriesClient.DeleteDirectory.g.cs
#nullable enable

namespace G
{
    public partial interface IDirectoriesClient
    {
        /// <summary>
        /// Delete Directory
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteDirectoryAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}