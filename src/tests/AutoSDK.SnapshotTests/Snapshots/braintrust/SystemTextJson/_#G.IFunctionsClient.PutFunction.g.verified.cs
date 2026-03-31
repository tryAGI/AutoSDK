//HintName: G.IFunctionsClient.PutFunction.g.cs
#nullable enable

namespace G
{
    public partial interface IFunctionsClient
    {
        /// <summary>
        /// Create or replace function<br/>
        /// Create or replace function. If there is an existing function in the project with the same slug as the one specified in the request, will replace the existing function with the provided fields
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Function2> PutFunctionAsync(

            global::G.CreateFunction request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create or replace function<br/>
        /// Create or replace function. If there is an existing function in the project with the same slug as the one specified in the request, will replace the existing function with the provided fields
        /// </summary>
        /// <param name="projectId">
        /// Unique identifier for the project that the prompt belongs under
        /// </param>
        /// <param name="name">
        /// Name of the prompt
        /// </param>
        /// <param name="slug">
        /// Unique identifier for the prompt
        /// </param>
        /// <param name="description">
        /// Textual description of the prompt
        /// </param>
        /// <param name="promptData">
        /// The prompt, model, and its parameters
        /// </param>
        /// <param name="tags">
        /// A list of tags for the prompt
        /// </param>
        /// <param name="functionType"></param>
        /// <param name="functionData"></param>
        /// <param name="origin"></param>
        /// <param name="functionSchema">
        /// JSON schema for the function's parameters and return type
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Function2> PutFunctionAsync(
            global::System.Guid projectId,
            string name,
            string slug,
            global::G.FunctionData functionData,
            string? description = default,
            global::G.PromptDataNullish? promptData = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::G.FunctionTypeEnumNullish? functionType = default,
            global::G.CreateFunctionOrigin? origin = default,
            global::G.CreateFunctionFunctionSchema? functionSchema = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}