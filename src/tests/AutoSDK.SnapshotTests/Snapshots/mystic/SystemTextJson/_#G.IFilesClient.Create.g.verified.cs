//HintName: G.IFilesClient.Create.g.cs
#nullable enable

namespace G
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Create<br/>
        /// Create a new file.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CreateAsync(

            global::G.BodyCreateV4FilesPost request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create<br/>
        /// Create a new file.
        /// </summary>
        /// <param name="pfile"></param>
        /// <param name="pfilename"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> CreateAsync(
            byte[] pfile,
            string pfilename,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}