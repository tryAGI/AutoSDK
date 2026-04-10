//HintName: G.IRestClient.PatchPromptTemplateVersion.g.cs
#nullable enable

namespace G
{
    public partial interface IRestClient
    {
        /// <summary>
        /// Patch Prompt Template Version<br/>
        /// Partially update a prompt template by creating a new version with merged changes. This endpoint fetches a base version (latest by default), applies your patches, validates the result, and creates a new version.
        /// </summary>
        /// <param name="identifier">
        /// The prompt template name or ID.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreatePromptTemplateResponse> PatchPromptTemplateVersionAsync(
            string identifier,

            global::G.PatchPromptTemplateVersion request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Patch Prompt Template Version<br/>
        /// Partially update a prompt template by creating a new version with merged changes. This endpoint fetches a base version (latest by default), applies your patches, validates the result, and creates a new version.
        /// </summary>
        /// <param name="identifier">
        /// The prompt template name or ID.
        /// </param>
        /// <param name="version">
        /// The base version number to patch from. Mutually exclusive with `label`. If neither is provided, the latest version is used.
        /// </param>
        /// <param name="label">
        /// The release label identifying the base version to patch from (e.g. 'prod', 'staging'). Mutually exclusive with `version`.
        /// </param>
        /// <param name="messages">
        /// Patch for chat template messages. Pass an object with index keys for index-based patching, or an array for full replacement. Chat templates only.
        /// </param>
        /// <param name="tools">
        /// Patch for tools. Object for index-based patching, array for full replacement, null to remove. Chat templates only.
        /// </param>
        /// <param name="functions">
        /// Patch for functions. Object for index-based patching, array for full replacement, null to remove. Chat templates only.
        /// </param>
        /// <param name="functionCall">
        /// Replace the function_call setting. Set to null to remove. Chat templates only.
        /// </param>
        /// <param name="toolChoice">
        /// Replace the tool_choice setting. Set to null to remove. Chat templates only.
        /// </param>
        /// <param name="content">
        /// Patch for completion template content. Object for index-based patching, array for full replacement. Completion templates only.
        /// </param>
        /// <param name="modelParameters">
        /// Parameters to shallow-merge into the existing model parameters (e.g. temperature, max_tokens). Existing keys not specified here are preserved.
        /// </param>
        /// <param name="responseFormat">
        /// Convenience field to set response_format in model parameters. Cannot be used simultaneously with response_format inside model_parameters. Set to null to remove.
        /// </param>
        /// <param name="commitMessage">
        /// A message describing the changes in this version.
        /// </param>
        /// <param name="releaseLabels">
        /// Release labels to create or move to the newly created version (e.g. ['staging', 'production']).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreatePromptTemplateResponse> PatchPromptTemplateVersionAsync(
            string identifier,
            int? version = default,
            string? label = default,
            global::G.AnyOf<object, global::System.Collections.Generic.IList<object>, object>? messages = default,
            global::G.AnyOf<object, global::System.Collections.Generic.IList<object>, object>? tools = default,
            global::G.AnyOf<object, global::System.Collections.Generic.IList<object>, object>? functions = default,
            global::G.AnyOf<string, object, object>? functionCall = default,
            global::G.AnyOf<string, object, object>? toolChoice = default,
            global::G.AnyOf<object, global::System.Collections.Generic.IList<object>, object>? content = default,
            object? modelParameters = default,
            object? responseFormat = default,
            string? commitMessage = default,
            global::System.Collections.Generic.IList<string>? releaseLabels = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}