//HintName: G.IFilesClient.CreateFile.g.cs
#nullable enable

namespace G
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Upload a file that can be used across various endpoints. Individual files can be up to 512 MB, and the size of all files uploaded by one organization can be up to 100 GB.<br/>
        /// The Assistants API supports files up to 2 million tokens and of specific file types. See the [Assistants Tools guide](/docs/assistants/tools) for details.<br/>
        /// The Fine-tuning API only supports `.jsonl` files. The input also has certain required formats for fine-tuning [chat](/docs/api-reference/fine-tuning/chat-input) or [completions](/docs/api-reference/fine-tuning/completions-input) models.<br/>
        /// The Batch API only supports `.jsonl` files up to 200 MB in size. The input also has a specific required [format](/docs/api-reference/batch/request-input).<br/>
        /// Please [contact us](https://help.openai.com/) if you need to increase these storage limits.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.OpenAIFile> CreateFileAsync(
            global::G.CreateFileRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Upload a file that can be used across various endpoints. Individual files can be up to 512 MB, and the size of all files uploaded by one organization can be up to 100 GB.<br/>
        /// The Assistants API supports files up to 2 million tokens and of specific file types. See the [Assistants Tools guide](/docs/assistants/tools) for details.<br/>
        /// The Fine-tuning API only supports `.jsonl` files. The input also has certain required formats for fine-tuning [chat](/docs/api-reference/fine-tuning/chat-input) or [completions](/docs/api-reference/fine-tuning/completions-input) models.<br/>
        /// The Batch API only supports `.jsonl` files up to 200 MB in size. The input also has a specific required [format](/docs/api-reference/batch/request-input).<br/>
        /// Please [contact us](https://help.openai.com/) if you need to increase these storage limits.
        /// </summary>
        /// <param name="file">
        /// The File object (not file name) to be uploaded.
        /// </param>
        /// <param name="filename">
        /// The File object (not file name) to be uploaded.
        /// </param>
        /// <param name="purpose">
        /// The intended purpose of the uploaded file.<br/>
        /// Use "assistants" for [Assistants](/docs/api-reference/assistants) and [Message](/docs/api-reference/messages) files, "vision" for Assistants image file inputs, "batch" for [Batch API](/docs/guides/batch), and "fine-tune" for [Fine-tuning](/docs/api-reference/fine-tuning).
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