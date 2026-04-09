//HintName: G.IToolsApiClient.CreateToolsAiDetect.g.cs
#nullable enable

namespace G
{
    public partial interface IToolsApiClient
    {
        /// <summary>
        /// AI detection<br/>
        /// Detects if content is AI- or human-generated, with a confidence score. Content must have at least 350 characters
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// curl --location --request POST https://api.writer.com/v1/tools/ai-detect \<br/>
        ///  --header "Authorization: Bearer &lt;token&gt;" \<br/>
        ///  --header "Content-Type: application/json" \<br/>
        /// --data-raw '{"input":"AI and ML continue to be at the forefront of technological advancements. In 2025, we can expect more sophisticated AI systems that can handle complex tasks with greater efficiency. AI will play a crucial role in various sectors, including healthcare, finance, and manufacturing. For instance, AI-powered diagnostic tools will become more accurate, helping doctors detect diseases at an early stage. In finance, AI algorithms will enhance fraud detection and risk management."}'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::G.AiDetectionResponse> CreateToolsAiDetectAsync(

            global::G.AiDetectionRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// AI detection<br/>
        /// Detects if content is AI- or human-generated, with a confidence score. Content must have at least 350 characters
        /// </summary>
        /// <param name="input">
        /// The content to determine if it is AI- or human-generated. Content must have at least 350 characters.<br/>
        /// Example: AI and ML continue to be at the forefront of technological advancements. In 2025, we can expect more sophisticated AI systems that can handle complex tasks with greater efficiency. AI will play a crucial role in various sectors, including healthcare, finance, and manufacturing. For instance, AI-powered diagnostic tools will become more accurate, helping doctors detect diseases at an early stage. In finance, AI algorithms will enhance fraud detection and risk management.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AiDetectionResponse> CreateToolsAiDetectAsync(
            string input,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}