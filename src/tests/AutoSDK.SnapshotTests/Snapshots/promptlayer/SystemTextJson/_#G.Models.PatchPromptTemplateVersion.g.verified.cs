//HintName: G.Models.PatchPromptTemplateVersion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchPromptTemplateVersion
    {
        /// <summary>
        /// The base version number to patch from. Mutually exclusive with `label`. If neither is provided, the latest version is used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public int? Version { get; set; }

        /// <summary>
        /// The release label identifying the base version to patch from (e.g. 'prod', 'staging'). Mutually exclusive with `version`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Patch for chat template messages. Pass an object with index keys for index-based patching, or an array for full replacement. Chat templates only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, object>))]
        public global::G.AnyOf<object, global::System.Collections.Generic.IList<object>, object>? Messages { get; set; }

        /// <summary>
        /// Patch for tools. Object for index-based patching, array for full replacement, null to remove. Chat templates only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, object>))]
        public global::G.AnyOf<object, global::System.Collections.Generic.IList<object>, object>? Tools { get; set; }

        /// <summary>
        /// Patch for functions. Object for index-based patching, array for full replacement, null to remove. Chat templates only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("functions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, object>))]
        public global::G.AnyOf<object, global::System.Collections.Generic.IList<object>, object>? Functions { get; set; }

        /// <summary>
        /// Replace the function_call setting. Set to null to remove. Chat templates only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function_call")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<string, object, object>))]
        public global::G.AnyOf<string, object, object>? FunctionCall { get; set; }

        /// <summary>
        /// Replace the tool_choice setting. Set to null to remove. Chat templates only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<string, object, object>))]
        public global::G.AnyOf<string, object, object>? ToolChoice { get; set; }

        /// <summary>
        /// Patch for completion template content. Object for index-based patching, array for full replacement. Completion templates only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, object>))]
        public global::G.AnyOf<object, global::System.Collections.Generic.IList<object>, object>? Content { get; set; }

        /// <summary>
        /// Parameters to shallow-merge into the existing model parameters (e.g. temperature, max_tokens). Existing keys not specified here are preserved.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_parameters")]
        public object? ModelParameters { get; set; }

        /// <summary>
        /// Convenience field to set response_format in model parameters. Cannot be used simultaneously with response_format inside model_parameters. Set to null to remove.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        public object? ResponseFormat { get; set; }

        /// <summary>
        /// A message describing the changes in this version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_message")]
        public string? CommitMessage { get; set; }

        /// <summary>
        /// Release labels to create or move to the newly created version (e.g. ['staging', 'production']).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("release_labels")]
        public global::System.Collections.Generic.IList<string>? ReleaseLabels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchPromptTemplateVersion" /> class.
        /// </summary>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchPromptTemplateVersion(
            int? version,
            string? label,
            global::G.AnyOf<object, global::System.Collections.Generic.IList<object>, object>? messages,
            global::G.AnyOf<object, global::System.Collections.Generic.IList<object>, object>? tools,
            global::G.AnyOf<object, global::System.Collections.Generic.IList<object>, object>? functions,
            global::G.AnyOf<string, object, object>? functionCall,
            global::G.AnyOf<string, object, object>? toolChoice,
            global::G.AnyOf<object, global::System.Collections.Generic.IList<object>, object>? content,
            object? modelParameters,
            object? responseFormat,
            string? commitMessage,
            global::System.Collections.Generic.IList<string>? releaseLabels)
        {
            this.Version = version;
            this.Label = label;
            this.Messages = messages;
            this.Tools = tools;
            this.Functions = functions;
            this.FunctionCall = functionCall;
            this.ToolChoice = toolChoice;
            this.Content = content;
            this.ModelParameters = modelParameters;
            this.ResponseFormat = responseFormat;
            this.CommitMessage = commitMessage;
            this.ReleaseLabels = releaseLabels;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchPromptTemplateVersion" /> class.
        /// </summary>
        public PatchPromptTemplateVersion()
        {
        }
    }
}