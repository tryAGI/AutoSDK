//HintName: G.IToolsApiClient.CreateToolsContextAwareSplitting.g.cs
#nullable enable

namespace G
{
    public partial interface IToolsApiClient
    {
        /// <summary>
        /// Context-aware text splitting<br/>
        /// Splits a long block of text (maximum 4000 words) into smaller chunks while preserving the semantic meaning of the text and context between the chunks.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// curl --location --request POST https://api.writer.com/v1/tools/context-aware-splitting \<br/>
        ///  --header "Authorization: Bearer &lt;token&gt;" \<br/>
        ///  --header "Content-Type: application/json" \<br/>
        /// --data-raw '{"text":"text to split","strategy":"llm_split"}'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::G.ContextAwareSplittingResponse> CreateToolsContextAwareSplittingAsync(

            global::G.ContextAwareTextSplittingRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Context-aware text splitting<br/>
        /// Splits a long block of text (maximum 4000 words) into smaller chunks while preserving the semantic meaning of the text and context between the chunks.
        /// </summary>
        /// <param name="text">
        /// The text to split into chunks.
        /// </param>
        /// <param name="strategy"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ContextAwareSplittingResponse> CreateToolsContextAwareSplittingAsync(
            string text,
            global::G.SplittingStrategy strategy,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}