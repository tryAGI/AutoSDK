//HintName: G.IFilesClient.CreateFile.g.cs
#nullable enable

namespace G
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Upload a file to be used across various endpoints, such as Assistant (&lt;2M tokens), Fine-Tuning, and Batch (&lt;100 MB). Total size of your bucket is 100 GB.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.OpenAIFile> CreateFileAsync(

            global::G.CreateFileRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload a file to be used across various endpoints, such as Assistant (&lt;2M tokens), Fine-Tuning, and Batch (&lt;100 MB). Total size of your bucket is 100 GB.
        /// </summary>
        /// <param name="file">
        /// The File object (not file name) to be uploaded.
        /// </param>
        /// <param name="filename">
        /// The File object (not file name) to be uploaded.
        /// </param>
        /// <param name="purpose">
        /// The intended purpose of the uploaded file.<br/>
        /// Use "assistants" for [Assistants](https://platform.openai.com/docs/api-reference/assistants) and [Message](https://platform.openai.com/docs/api-reference/messages) files, "vision" for Assistants image file inputs, "batch" for [Batch API](https://platform.openai.com/docs/guides/batch), and "fine-tune" for [Fine-tuning](https://platform.openai.com/docs/api-reference/fine-tuning).
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.OpenAIFile> CreateFileAsync(
            byte[] file,
            string filename,
            global::G.CreateFileRequestPurpose purpose,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}