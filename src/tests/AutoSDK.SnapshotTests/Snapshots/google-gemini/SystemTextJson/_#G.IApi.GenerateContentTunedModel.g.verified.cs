//HintName: G.IApi.GenerateContentTunedModel.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Generates a response from the model given an input `GenerateContentRequest`.
        /// </summary>
        /// <param name="tunedModelId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GenerateContentResponse> GenerateContentTunedModelAsync(
            string tunedModelId,
            global::G.GenerateContentRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Generates a response from the model given an input `GenerateContentRequest`.
        /// </summary>
        /// <param name="tunedModelId"></param>
        /// <param name="generationConfig">
        /// Configuration options for model generation and outputs. Not all parameters may be configurable for every model.
        /// </param>
        /// <param name="contents">
        /// Required. The content of the current conversation with the model. For single-turn queries, this is a single instance. For multi-turn queries, this is a repeated field that contains conversation history + latest request.
        /// </param>
        /// <param name="safetySettings">
        /// Optional. A list of unique `SafetySetting` instances for blocking unsafe content. This will be enforced on the `GenerateContentRequest.contents` and `GenerateContentResponse.candidates`. There should not be more than one setting for each `SafetyCategory` type. The API will block any contents and responses that fail to meet the thresholds set by these settings. This list overrides the default settings for each `SafetyCategory` specified in the safety_settings. If there is no `SafetySetting` for a given `SafetyCategory` provided in the list, the API will use the default safety setting for that category. Harm categories HARM_CATEGORY_HATE_SPEECH, HARM_CATEGORY_SEXUALLY_EXPLICIT, HARM_CATEGORY_DANGEROUS_CONTENT, HARM_CATEGORY_HARASSMENT are supported.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GenerateContentResponse> GenerateContentTunedModelAsync(
            string tunedModelId,
            global::G.GenerationConfig? generationConfig = default,
            global::System.Collections.Generic.IList<global::G.Content>? contents = default,
            global::System.Collections.Generic.IList<global::G.SafetySetting>? safetySettings = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}