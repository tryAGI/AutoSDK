//HintName: G.Models.UpdatePromptRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdatePromptRequest
    {
        /// <summary>
        /// When `true`, enables partial version updates. Missing version fields (`string`, `parameters`, `model`) are backfilled from the current latest version, so you only need to provide the fields you want to change. When `false` or omitted, the original strict validation is preserved for backward compatibility.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("patch")]
        public bool? Patch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collection_id")]
        public string? CollectionId { get; set; }

        /// <summary>
        /// The prompt template string. When `patch` is `true`, this field is optional and will be inherited from the current latest version if omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("string")]
        public string? String { get; set; }

        /// <summary>
        /// Model parameters (e.g. temperature, max_tokens). When `patch` is `true`, this field is optional and will be inherited from the current latest version if omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public object? Parameters { get; set; }

        /// <summary>
        /// The model identifier. When `patch` is `true`, this field is optional and will be inherited from the current latest version if omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The virtual key to associate with this version. When `patch` is `true`, this field is optional and will be inherited from the current latest version if omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("virtual_key")]
        public string? VirtualKey { get; set; }

        /// <summary>
        /// A human-readable description for this version. When `patch` is `true`, this field is optional and will be inherited from the current latest version if omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_description")]
        public string? VersionDescription { get; set; }

        /// <summary>
        /// Function definitions available to the model. When `patch` is `true`, this field is optional and will be inherited from the current latest version if omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("functions")]
        public global::System.Collections.Generic.IList<object>? Functions { get; set; }

        /// <summary>
        /// Tool definitions available to the model. When `patch` is `true`, this field is optional and will be inherited from the current latest version if omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<object>? Tools { get; set; }

        /// <summary>
        /// Controls which tool the model uses. When `patch` is `true`, this field is optional and will be inherited from the current latest version if omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        public object? ToolChoice { get; set; }

        /// <summary>
        /// Whether the template string is raw (1) or processed (0). When `patch` is `true`, this field is optional and will be inherited from the current latest version if omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_raw_template")]
        public int? IsRawTemplate { get; set; }

        /// <summary>
        /// Additional metadata for the prompt version. When `patch` is `true`, this field is optional and will be inherited from the current latest version if omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_metadata")]
        public object? PromptMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePromptRequest" /> class.
        /// </summary>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdatePromptRequest(
            bool? patch,
            string? name,
            string? collectionId,
            string? @string,
            object? parameters,
            string? model,
            string? virtualKey,
            string? versionDescription,
            global::System.Collections.Generic.IList<object>? functions,
            global::System.Collections.Generic.IList<object>? tools,
            object? toolChoice,
            int? isRawTemplate,
            object? promptMetadata)
        {
            this.Patch = patch;
            this.Name = name;
            this.CollectionId = collectionId;
            this.String = @string;
            this.Parameters = parameters;
            this.Model = model;
            this.VirtualKey = virtualKey;
            this.VersionDescription = versionDescription;
            this.Functions = functions;
            this.Tools = tools;
            this.ToolChoice = toolChoice;
            this.IsRawTemplate = isRawTemplate;
            this.PromptMetadata = promptMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePromptRequest" /> class.
        /// </summary>
        public UpdatePromptRequest()
        {
        }
    }
}