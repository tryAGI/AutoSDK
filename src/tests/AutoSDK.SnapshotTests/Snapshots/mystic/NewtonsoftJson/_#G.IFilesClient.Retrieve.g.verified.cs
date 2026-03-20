//HintName: G.IFilesClient.Retrieve.g.cs
#nullable enable

namespace G
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Retrieve<br/>
        /// Retrieve a file instance.
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> RetrieveAsync(
            string fileId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}