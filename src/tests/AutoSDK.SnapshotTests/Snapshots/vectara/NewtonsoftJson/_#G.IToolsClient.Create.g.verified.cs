//HintName: G.IToolsClient.Create.g.cs
#nullable enable

namespace G
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// Create tool<br/>
        /// Create a new tool that agents can use during conversation. Tools give agents capabilities to interact with external systems, process data, query corpora, or run custom logic. Agents select and invoke tools dynamically based on their instructions and the conversational context.<br/>
        /// Vectara provides several built-in tools, but you can also create your own. This endpoint currently supports creating **Lambda tools**, which run user-defined Python functions in a secure sandbox.<br/>
        /// Each tool is defined by:<br/>
        /// - A unique tool ID<br/>
        /// - A description of its purpose<br/>
        /// - An input schema describing accepted parameters<br/>
        /// - Optional metadata<br/>
        /// - Enabled/disabled runtime availability<br/>
        ///  ## Artifact-based tools<br/>
        /// Some built-in tools work with artifacts stored in a session:<br/>
        /// - **Document conversion tool**: Converts file artifacts (PDF, Word, PowerPoint, images with OCR support) to markdown and produces new artifacts containing the extracted content.<br/>
        /// These built-in tools operate on artifact references rather than file content, supporting multi-step workflows where agents process or index user-uploaded documents.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Tool> CreateAsync(

            global::G.CreateToolRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}