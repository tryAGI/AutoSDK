//HintName: G.ITranscriptClient.UploadFile.g.cs
#nullable enable

namespace G
{
    public partial interface ITranscriptClient
    {
        /// <summary>
        /// Upload a media file<br/>
        /// Upload a media file to AssemblyAI's servers.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UploadedFile> UploadFileAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}