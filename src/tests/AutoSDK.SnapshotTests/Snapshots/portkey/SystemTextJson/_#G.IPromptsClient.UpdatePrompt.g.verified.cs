//HintName: G.IPromptsClient.UpdatePrompt.g.cs
#nullable enable

namespace G
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Update a prompt<br/>
        /// Update a prompt's metadata and/or create a new version with updated template content.<br/>
        /// **Partial version updates:** Set `patch: true` to perform a partial update of version fields (`string`, `parameters`, `model`, `virtual_key`, `version_description`, `functions`, `tools`, `tool_choice`, `is_raw_template`, `prompt_metadata`). When enabled, any version fields omitted from the request are backfilled from the current latest version, allowing you to update only the fields you need. When `patch` is omitted or `false`, all version fields must be provided together (original strict validation).<br/>
        /// **Metadata-only updates:** Fields like `name`, `collection_id`, `version_description`, and `virtual_key` can always be updated independently without affecting versioning.
        /// </summary>
        /// <param name="promptId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdatePromptResponse> UpdatePromptAsync(
            string promptId,

            global::G.UpdatePromptRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a prompt<br/>
        /// Update a prompt's metadata and/or create a new version with updated template content.<br/>
        /// **Partial version updates:** Set `patch: true` to perform a partial update of version fields (`string`, `parameters`, `model`, `virtual_key`, `version_description`, `functions`, `tools`, `tool_choice`, `is_raw_template`, `prompt_metadata`). When enabled, any version fields omitted from the request are backfilled from the current latest version, allowing you to update only the fields you need. When `patch` is omitted or `false`, all version fields must be provided together (original strict validation).<br/>
        /// **Metadata-only updates:** Fields like `name`, `collection_id`, `version_description`, and `virtual_key` can always be updated independently without affecting versioning.
        /// </summary>
        /// <param name="promptId"></param>
        /// <param name="patch">
        /// When `true`, enables partial version updates. Missing version fields (`string`, `parameters`, `model`) are backfilled from the current latest version, so you only need to provide the fields you want to change. When `false` or omitted, the original strict validation is preserved for backward compatibility.
        /// </param>
        /// <param name="name"></param>
        /// <param name="collectionId"></param>
        /// <param name="string">
        /// The prompt template string. When `patch` is `true`, this field is optional and will be inherited from the current latest version if omitted.
        /// </param>
        /// <param name="parameters">
        /// Model parameters (e.g. temperature, max_tokens). When `patch` is `true`, this field is optional and will be inherited from the current latest version if omitted.
        /// </param>
        /// <param name="model">
        /// The model identifier. When `patch` is `true`, this field is optional and will be inherited from the current latest version if omitted.
        /// </param>
        /// <param name="virtualKey">
        /// The virtual key to associate with this version. When `patch` is `true`, this field is optional and will be inherited from the current latest version if omitted.
        /// </param>
        /// <param name="versionDescription">
        /// A human-readable description for this version. When `patch` is `true`, this field is optional and will be inherited from the current latest version if omitted.
        /// </param>
        /// <param name="functions">
        /// Function definitions available to the model. When `patch` is `true`, this field is optional and will be inherited from the current latest version if omitted.
        /// </param>
        /// <param name="tools">
        /// Tool definitions available to the model. When `patch` is `true`, this field is optional and will be inherited from the current latest version if omitted.
        /// </param>
        /// <param name="toolChoice">
        /// Controls which tool the model uses. When `patch` is `true`, this field is optional and will be inherited from the current latest version if omitted.
        /// </param>
        /// <param name="isRawTemplate">
        /// Whether the template string is raw (1) or processed (0). When `patch` is `true`, this field is optional and will be inherited from the current latest version if omitted.
        /// </param>
        /// <param name="promptMetadata">
        /// Additional metadata for the prompt version. When `patch` is `true`, this field is optional and will be inherited from the current latest version if omitted.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdatePromptResponse> UpdatePromptAsync(
            string promptId,
            bool? patch = default,
            string? name = default,
            string? collectionId = default,
            string? @string = default,
            object? parameters = default,
            string? model = default,
            string? virtualKey = default,
            string? versionDescription = default,
            global::System.Collections.Generic.IList<object>? functions = default,
            global::System.Collections.Generic.IList<object>? tools = default,
            object? toolChoice = default,
            int? isRawTemplate = default,
            object? promptMetadata = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}