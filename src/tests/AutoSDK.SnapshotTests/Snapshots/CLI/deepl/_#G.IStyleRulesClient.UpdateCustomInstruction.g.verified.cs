//HintName: G.IStyleRulesClient.UpdateCustomInstruction.g.cs
#nullable enable

namespace G
{
    public partial interface IStyleRulesClient
    {
        /// <summary>
        /// Update a custom instruction
        /// </summary>
        /// <param name="styleId"></param>
        /// <param name="instructionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CustomInstruction> UpdateCustomInstructionAsync(
            string styleId,
            string instructionId,

            global::G.CustomInstructionRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a custom instruction
        /// </summary>
        /// <param name="styleId"></param>
        /// <param name="instructionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse<global::G.CustomInstruction>> UpdateCustomInstructionAsResponseAsync(
            string styleId,
            string instructionId,

            global::G.CustomInstructionRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a custom instruction
        /// </summary>
        /// <param name="styleId"></param>
        /// <param name="instructionId"></param>
        /// <param name="label">
        /// Name associated with the custom instruction<br/>
        /// Example: Currency custom instruction
        /// </param>
        /// <param name="prompt">
        /// Prompt of the custom instruction<br/>
        /// Example: Have currency symbols before the numerical value (e.g. $100, €100)
        /// </param>
        /// <param name="sourceLanguage">
        /// Optional source language of the custom instruction<br/>
        /// Example: en
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CustomInstruction> UpdateCustomInstructionAsync(
            string styleId,
            string instructionId,
            string label,
            string prompt,
            string? sourceLanguage = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}