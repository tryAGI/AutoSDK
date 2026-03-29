//HintName: G.IApi.ExtensionsUpload.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Upload an Extension
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Extension> ExtensionsUploadAsync(

            global::G.ExtensionsUploadRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload an Extension
        /// </summary>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Extension> ExtensionsUploadAsync(
            byte[] file,
            string filename,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}