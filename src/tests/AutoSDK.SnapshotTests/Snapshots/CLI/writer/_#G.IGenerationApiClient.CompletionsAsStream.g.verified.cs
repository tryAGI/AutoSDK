//HintName: G.IGenerationApiClient.CompletionsAsStream.g.cs
#nullable enable

namespace G
{
    public partial interface IGenerationApiClient
    {
        /// <summary>
        /// Text generation<br/>
        /// Generate text completions using the specified model and prompt. This endpoint is useful for text generation tasks that don't require conversational context.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// curl --location --request POST https://api.writer.com/v1/completions \<br/>
        ///  --header "Authorization: Bearer &lt;token&gt;" \<br/>
        ///  --header "Content-Type: application/json" \<br/>
        /// --data-raw '{"model":"palmyra-x-003-instruct","prompt":"Write me a short SEO article about camping gear","max_tokens":150,"temperature":0.7,"top_p":0.9,"stop":["."],"best_of":1,"random_seed":42,"stream":false}'
        /// </remarks>
        global::System.Collections.Generic.IAsyncEnumerable<global::G.StreamingData> CompletionsAsStreamAsync(

            global::G.CompletionsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Text generation<br/>
        /// Generate text completions using the specified model and prompt. This endpoint is useful for text generation tasks that don't require conversational context.
        /// </summary>
        /// <param name="model">
        /// The [ID of the model](https://dev.writer.com/home/models) to use for generating text. Supports `palmyra-x5`, `palmyra-x4`, `palmyra-fin`, `palmyra-med`, `palmyra-creative`, and `palmyra-x-003-instruct`.
        /// </param>
        /// <param name="prompt">
        /// The input text that the model will process to generate a response.
        /// </param>
        /// <param name="maxTokens">
        /// The maximum number of tokens that the model can generate in the response.
        /// </param>
        /// <param name="temperature">
        /// Controls the randomness of the model's outputs. Higher values lead to more random outputs, while lower values make the model more deterministic.
        /// </param>
        /// <param name="topP">
        /// Used to control the nucleus sampling, where only the most probable tokens with a cumulative probability of top_p are considered for sampling, providing a way to fine-tune the randomness of predictions.
        /// </param>
        /// <param name="stop">
        /// Specifies stopping conditions for the model's output generation. This can be an array of strings or a single string that the model will look for as a signal to stop generating further tokens.
        /// </param>
        /// <param name="bestOf">
        /// Specifies the number of completions to generate and return the best one. Useful for generating multiple outputs and choosing the best based on some criteria.
        /// </param>
        /// <param name="randomSeed">
        /// A seed used to initialize the random number generator for the model, ensuring reproducibility of the output when the same inputs are provided.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::G.StreamingData> CompletionsAsStreamAsync(
            string model,
            string prompt,
            long? maxTokens = default,
            double? temperature = default,
            double? topP = default,
            global::G.OneOf<global::System.Collections.Generic.IList<string>, string>? stop = default,
            int? bestOf = default,
            int? randomSeed = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}