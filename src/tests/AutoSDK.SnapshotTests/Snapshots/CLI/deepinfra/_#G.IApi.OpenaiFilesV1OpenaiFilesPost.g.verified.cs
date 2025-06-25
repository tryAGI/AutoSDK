//HintName: G.IApi.OpenaiFilesV1OpenaiFilesPost.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Openai Files
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> OpenaiFilesV1OpenaiFilesPostAsync(
            global::G.BodyOpenaiFilesV1OpenaiFilesPost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Openai Files
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="purpose"></param>
        /// <param name="file"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> OpenaiFilesV1OpenaiFilesPostAsync(
            string purpose,
            global::System.Collections.Generic.IList<byte[]> file,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}