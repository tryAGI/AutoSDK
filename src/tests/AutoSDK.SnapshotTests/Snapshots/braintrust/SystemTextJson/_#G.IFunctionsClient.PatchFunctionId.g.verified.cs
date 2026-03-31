//HintName: G.IFunctionsClient.PatchFunctionId.g.cs
#nullable enable

namespace G
{
    public partial interface IFunctionsClient
    {
        /// <summary>
        /// Partially update function<br/>
        /// Partially update a function object. Specify the fields to update in the payload. Any object-type fields will be deep-merged with existing content. Currently we do not support removing fields or setting them to null.
        /// </summary>
        /// <param name="functionId">
        /// Function id
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Function2> PatchFunctionIdAsync(
            global::System.Guid functionId,

            global::G.PatchFunction request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Partially update function<br/>
        /// Partially update a function object. Specify the fields to update in the payload. Any object-type fields will be deep-merged with existing content. Currently we do not support removing fields or setting them to null.
        /// </summary>
        /// <param name="functionId">
        /// Function id
        /// </param>
        /// <param name="name">
        /// Name of the prompt
        /// </param>
        /// <param name="description">
        /// Textual description of the prompt
        /// </param>
        /// <param name="promptData">
        /// The prompt, model, and its parameters
        /// </param>
        /// <param name="functionData"></param>
        /// <param name="tags">
        /// A list of tags for the prompt
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Function2> PatchFunctionIdAsync(
            global::System.Guid functionId,
            string? name = default,
            string? description = default,
            global::G.PromptDataNullish? promptData = default,
            global::G.FunctionDataNullish? functionData = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}