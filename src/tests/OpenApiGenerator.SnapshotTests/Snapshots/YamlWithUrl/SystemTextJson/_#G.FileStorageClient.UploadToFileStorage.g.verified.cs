//HintName: G.FileStorageClient.UploadToFileStorage.g.cs

#nullable enable

namespace G
{
    public partial class FileStorageClient
    {
        /// <summary>
        /// Returns data path.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="name"></param>
        /// <param name="projectId"></param>
        /// <param name="uploadType"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task UploadToFileStorageAsync(
            string token,
            string name,
            string projectId,
            int uploadType,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/api/v1/uploadtofilestorage?name={name}&projectId={projectId}&uploadType={uploadType}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}