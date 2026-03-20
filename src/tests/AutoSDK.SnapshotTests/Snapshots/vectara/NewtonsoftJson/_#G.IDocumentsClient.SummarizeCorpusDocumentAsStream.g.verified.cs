//HintName: G.IDocumentsClient.SummarizeCorpusDocumentAsStream.g.cs
#nullable enable

namespace G
{
    public partial interface IDocumentsClient
    {
        /// <summary>
        /// Summarize a document<br/>
        /// Organizations often struggle with extracting relevant insights from extensive documentation, such as vendor quotes, financial statements, and technical reports. Manually reviewing these documents is both time-consuming and prone to errors. <br/>
        /// The tech preview of the Documentation Summarization API enables users to generate concise summaries that capture essential insights from single documents without having to process entire documents manually. Efficiently process large documents, extract key insights, and interact with real-time data summaries.<br/>
        /// * Enable streaming for large documents to receive summaries incrementally.<br/>
        /// * Customize `prompt_template` to fine-tune summary output for specific domains.<br/>
        /// * Use standard responses for small documents where streaming is unnecessary.<br/>
        /// * Monitor streaming events to track the progress of real-time summarization.<br/>
        /// :::note<br/>
        /// The documentation length is limited by the context window of your selected LLM.<br/>
        /// :::<br/>
        /// ## Response formats<br/>
        /// The API supports two response modes:<br/>
        /// * **Standard**: Provides a complete summary in one response.<br/>
        /// * **Streaming** Provides incremental responses using Server-Sent Events (SSE).<br/>
        /// ### Non-streaming response<br/>
        /// In standard mode, the API returns a structured response containing the complete summary of the document. The summary field contains the generated text, enabling users to extract essential information quickly.<br/>
        /// ### Streaming response<br/>
        /// For streaming responses, the API returns Server-Sent Events (SSE). The first event begins streaming partial results as soon as they are available, while the final event marks the end of the summarization process.<br/>
        /// The streamed response consists of multiple events:<br/>
        /// * `generation_info`: Contains the `rendered_prompt` which is the compiled prompt sent to the LLM for document summarization.<br/>
        /// * `generation_chunk`: Returns partial chunk of the generated summary.<br/>
        /// * `generation_end`: Marks the completion of the summary generation.<br/>
        /// * `error`: Returns an error message if summarization fails.<br/>
        /// * `end`: Indicates the end of the streaming session.<br/>
        /// ## Prompt template example<br/>
        /// When crafting a prompt, you can access your document with the `$vectaraDocument` field. This example shows a simple prompt:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "role": "user",<br/>
        ///   "content": "Summarize the document: \$vectaraDocument.json()"<br/>
        /// }<br/>
        /// ```<br/>
        /// The document also has the following methods to support custom prompts. <br/>
        /// * `$vectaraDocument.json()`: Provides a JSON representation of the whole document.<br/>
        /// * `$vectaraDocument.id()`: Specifies the unique identifier of the document (`document_id`)<br/>
        /// * `$vectaraDocument.metadata()`: Specifies metadata from the document.  <br/>
        ///   For example, <br/>
        ///   `$vectaraDocument.metadata().get("key")` retrieves a specific metadata value by key.<br/>
        /// * `$vectaraDocument.parts()`: Returns an array of document parts which you can look through.  <br/>
        ///   For example, `#foreach ($part in $vectaraDocument.parts())`.  <br/>
        /// * `$part.text()`: Retrieves the text of the part.<br/>
        /// * `$part.metadata()`: Retrieves metadata of a part.<br/>
        /// * `$part.hasTable()`: Determines if the part contains a table.<br/>
        /// * `$part.table()`: Provides access to the table within the part. For example, use `$part.table().json()` to retrieve the table in JSON format.
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
        global::System.Collections.Generic.IAsyncEnumerable<global::G.SummarizeDocumentStreamedResponse> SummarizeCorpusDocumentAsStreamAsync(
            string corpusKey,
            string documentId,

            global::G.SummarizeDocumentRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Summarize a document<br/>
        /// Organizations often struggle with extracting relevant insights from extensive documentation, such as vendor quotes, financial statements, and technical reports. Manually reviewing these documents is both time-consuming and prone to errors. <br/>
        /// The tech preview of the Documentation Summarization API enables users to generate concise summaries that capture essential insights from single documents without having to process entire documents manually. Efficiently process large documents, extract key insights, and interact with real-time data summaries.<br/>
        /// * Enable streaming for large documents to receive summaries incrementally.<br/>
        /// * Customize `prompt_template` to fine-tune summary output for specific domains.<br/>
        /// * Use standard responses for small documents where streaming is unnecessary.<br/>
        /// * Monitor streaming events to track the progress of real-time summarization.<br/>
        /// :::note<br/>
        /// The documentation length is limited by the context window of your selected LLM.<br/>
        /// :::<br/>
        /// ## Response formats<br/>
        /// The API supports two response modes:<br/>
        /// * **Standard**: Provides a complete summary in one response.<br/>
        /// * **Streaming** Provides incremental responses using Server-Sent Events (SSE).<br/>
        /// ### Non-streaming response<br/>
        /// In standard mode, the API returns a structured response containing the complete summary of the document. The summary field contains the generated text, enabling users to extract essential information quickly.<br/>
        /// ### Streaming response<br/>
        /// For streaming responses, the API returns Server-Sent Events (SSE). The first event begins streaming partial results as soon as they are available, while the final event marks the end of the summarization process.<br/>
        /// The streamed response consists of multiple events:<br/>
        /// * `generation_info`: Contains the `rendered_prompt` which is the compiled prompt sent to the LLM for document summarization.<br/>
        /// * `generation_chunk`: Returns partial chunk of the generated summary.<br/>
        /// * `generation_end`: Marks the completion of the summary generation.<br/>
        /// * `error`: Returns an error message if summarization fails.<br/>
        /// * `end`: Indicates the end of the streaming session.<br/>
        /// ## Prompt template example<br/>
        /// When crafting a prompt, you can access your document with the `$vectaraDocument` field. This example shows a simple prompt:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "role": "user",<br/>
        ///   "content": "Summarize the document: \$vectaraDocument.json()"<br/>
        /// }<br/>
        /// ```<br/>
        /// The document also has the following methods to support custom prompts. <br/>
        /// * `$vectaraDocument.json()`: Provides a JSON representation of the whole document.<br/>
        /// * `$vectaraDocument.id()`: Specifies the unique identifier of the document (`document_id`)<br/>
        /// * `$vectaraDocument.metadata()`: Specifies metadata from the document.  <br/>
        ///   For example, <br/>
        ///   `$vectaraDocument.metadata().get("key")` retrieves a specific metadata value by key.<br/>
        /// * `$vectaraDocument.parts()`: Returns an array of document parts which you can look through.  <br/>
        ///   For example, `#foreach ($part in $vectaraDocument.parts())`.  <br/>
        /// * `$part.text()`: Retrieves the text of the part.<br/>
        /// * `$part.metadata()`: Retrieves metadata of a part.<br/>
        /// * `$part.hasTable()`: Determines if the part contains a table.<br/>
        /// * `$part.table()`: Provides access to the table within the part. For example, use `$part.table().json()` to retrieve the table in JSON format.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="corpusKey">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>
        /// <param name="documentId"></param>
        /// <param name="llmName">
        /// The name of the LLM.<br/>
        /// Example: mockingbird-2.0
        /// </param>
        /// <param name="promptTemplate">
        /// The prompt template to use when generating the summary. Vectara manages both system and user roles and prompts for the generative LLM out of the box by default. However, users can override the `prompt_template` via this variable. The `prompt_template` is in the form of an Apache Velocity template. For more details on how to configure the `prompt_template`, see the [long-form documentation](https://docs.vectara.com/docs/prompts/vectara-prompt-engine).<br/>
        /// Example: Provide a concise summary of the document.
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
        global::System.Collections.Generic.IAsyncEnumerable<global::G.SummarizeDocumentStreamedResponse> SummarizeCorpusDocumentAsStreamAsync(
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