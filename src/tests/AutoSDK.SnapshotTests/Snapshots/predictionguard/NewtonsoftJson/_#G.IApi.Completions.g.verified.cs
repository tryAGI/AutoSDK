//HintName: G.IApi.Completions.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Completions<br/>
        /// Retrieve text completions based on the provided input.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CompletionsResponse200> CompletionsAsync(

            global::G.CompletionsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Completions<br/>
        /// Retrieve text completions based on the provided input.
        /// </summary>
        /// <param name="model">
        /// The chat model to use for generating completions.
        /// </param>
        /// <param name="prompt"></param>
        /// <param name="frequencyPenalty">
        /// A value between -2.0 and 2.0, with positive values increasingly penalizing new tokens based on their frequency so far in order to decrease further occurrences.
        /// </param>
        /// <param name="logitBias">
        /// Modifies the likelihood of specified tokens appearing in a response.
        /// </param>
        /// <param name="maxTokens">
        /// The maximum number of tokens in the generated completion.
        /// </param>
        /// <param name="presencePenalty">
        /// A value between -2.0 and 2.0, with positive values causing a flat reduction of new tokens based on their existing presence so far in order to decrease further occurrences.
        /// </param>
        /// <param name="stop"></param>
        /// <param name="stream">
        /// Whether to stream back the model response.
        /// </param>
        /// <param name="streamOptions">
        /// Extra parameters used when streaming the response.
        /// </param>
        /// <param name="temperature">
        /// The temperature parameter for controlling randomness in completions. Supports a range of 0.0-2.0.
        /// </param>
        /// <param name="topP">
        /// The diversity of the generated text based on nucleus sampling. Supports a range of 0.0-1.0.
        /// </param>
        /// <param name="topK">
        /// The diversity of the generated text based on top-k sampling.
        /// </param>
        /// <param name="output">
        /// Options to affect the output of the response.
        /// </param>
        /// <param name="input">
        /// Options to affect the input of the request.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CompletionsResponse200> CompletionsAsync(
            string model,
            global::G.CompletionsPostRequestBodyContentApplicationJsonSchemaPrompt prompt,
            double? frequencyPenalty = default,
            global::G.CompletionsPostRequestBodyContentApplicationJsonSchemaLogitBias? logitBias = default,
            int? maxTokens = default,
            double? presencePenalty = default,
            global::G.CompletionsPostRequestBodyContentApplicationJsonSchemaStop? stop = default,
            bool? stream = default,
            global::G.CompletionsPostRequestBodyContentApplicationJsonSchemaStreamOptions? streamOptions = default,
            double? temperature = default,
            double? topP = default,
            int? topK = default,
            global::G.CompletionsPostRequestBodyContentApplicationJsonSchemaOutput? output = default,
            global::G.CompletionsPostRequestBodyContentApplicationJsonSchemaInput? input = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}