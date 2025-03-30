//HintName: G.IDocumentsClient.SummarizeCorpusDocument.g.cs
#nullable enable

namespace G
{
    public partial interface IDocumentsClient
    {
        /// <summary>
        /// Summarize a document<br/>
        /// Summarize a document identified by its unique `document_id` from a specific corpus.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="corpusKey">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>
        /// <param name="documentId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.SummarizeDocumentResponse> SummarizeCorpusDocumentAsync(
            string corpusKey,
            string documentId,
            global::G.SummarizeDocumentRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Summarize a document<br/>
        /// Summarize a document identified by its unique `document_id` from a specific corpus.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="corpusKey">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>
        /// <param name="documentId"></param>
        /// <param name="llmName">
        /// The name of the LLM.
        /// </param>
        /// <param name="promptTemplate">
        /// The prompt template to use when generating the summary. <br/>
        /// Vectara manages both system and user roles and prompts for the generative<br/>
        /// LLM out of the box by default. However, users can override the<br/>
        /// `prompt_template` via this variable. The `prompt_template` is in the form of an<br/>
        /// Apache Velocity template. For more details on how to configure the<br/>
        /// `prompt_template`, see the [long-form documentation](https://docs.vectara.com/docs/prompts/vectara-prompt-engine).
        /// </param>
        /// <param name="modelParameters">
        /// Optional parameters for the specified model used when generating the summary.
        /// </param>
        /// <param name="streamResponse">
        /// Indicates whether the response should be streamed or not.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.SummarizeDocumentResponse> SummarizeCorpusDocumentAsync(
            string corpusKey,
            string documentId,
            string llmName,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? promptTemplate = default,
            object? modelParameters = default,
            bool? streamResponse = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}