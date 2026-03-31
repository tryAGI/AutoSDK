//HintName: G.Models.InvokeApi.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The request to invoke a function
    /// </summary>
    public sealed partial class InvokeApi
    {
        /// <summary>
        /// Argument to the function, which can be any JSON serializable value
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public object? Input { get; set; }

        /// <summary>
        /// The expected output of the function
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expected")]
        public object? Expected { get; set; }

        /// <summary>
        /// Any relevant metadata. This will be logged and available as the `metadata` argument.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, object?>? Metadata { get; set; }

        /// <summary>
        /// Any relevant tags to log on the span.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// If the function is an LLM, additional messages to pass along to it
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public global::System.Collections.Generic.IList<global::G.ChatCompletionMessageParam>? Messages { get; set; }

        /// <summary>
        /// Options for tracing the function call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.InvokeParentJsonConverter))]
        public global::G.InvokeParent? Parent { get; set; }

        /// <summary>
        /// Whether to stream the response. If true, results will be returned in the Braintrust SSE format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// The mode format of the returned value (defaults to 'auto')
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.StreamingModeJsonConverter))]
        public global::G.StreamingMode? Mode { get; set; }

        /// <summary>
        /// If true, throw an error if one of the variables in the prompt is not present in the input
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strict")]
        public bool? Strict { get; set; }

        /// <summary>
        /// Map of MCP server URL to auth credentials
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_auth")]
        public global::System.Collections.Generic.Dictionary<string, global::G.InvokeApiMcpAuth2>? McpAuth { get; set; }

        /// <summary>
        /// Partial function definition to merge with the function being invoked. Fields are validated against the function type's schema at runtime. For facets: { preprocessor?, prompt?, model? }. For prompts: { model?, ... }.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overrides")]
        public global::System.Collections.Generic.Dictionary<string, object?>? Overrides { get; set; }

        /// <summary>
        /// The version of the function
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InvokeApi" /> class.
        /// </summary>
        /// <param name="input">
        /// Argument to the function, which can be any JSON serializable value
        /// </param>
        /// <param name="expected">
        /// The expected output of the function
        /// </param>
        /// <param name="metadata">
        /// Any relevant metadata. This will be logged and available as the `metadata` argument.
        /// </param>
        /// <param name="tags">
        /// Any relevant tags to log on the span.
        /// </param>
        /// <param name="messages">
        /// If the function is an LLM, additional messages to pass along to it
        /// </param>
        /// <param name="parent">
        /// Options for tracing the function call
        /// </param>
        /// <param name="stream">
        /// Whether to stream the response. If true, results will be returned in the Braintrust SSE format.
        /// </param>
        /// <param name="mode">
        /// The mode format of the returned value (defaults to 'auto')
        /// </param>
        /// <param name="strict">
        /// If true, throw an error if one of the variables in the prompt is not present in the input
        /// </param>
        /// <param name="mcpAuth">
        /// Map of MCP server URL to auth credentials
        /// </param>
        /// <param name="overrides">
        /// Partial function definition to merge with the function being invoked. Fields are validated against the function type's schema at runtime. For facets: { preprocessor?, prompt?, model? }. For prompts: { model?, ... }.
        /// </param>
        /// <param name="version">
        /// The version of the function
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InvokeApi(
            object? input,
            object? expected,
            global::System.Collections.Generic.Dictionary<string, object?>? metadata,
            global::System.Collections.Generic.IList<string>? tags,
            global::System.Collections.Generic.IList<global::G.ChatCompletionMessageParam>? messages,
            global::G.InvokeParent? parent,
            bool? stream,
            global::G.StreamingMode? mode,
            bool? strict,
            global::System.Collections.Generic.Dictionary<string, global::G.InvokeApiMcpAuth2>? mcpAuth,
            global::System.Collections.Generic.Dictionary<string, object?>? overrides,
            string? version)
        {
            this.Input = input;
            this.Expected = expected;
            this.Metadata = metadata;
            this.Tags = tags;
            this.Messages = messages;
            this.Parent = parent;
            this.Stream = stream;
            this.Mode = mode;
            this.Strict = strict;
            this.McpAuth = mcpAuth;
            this.Overrides = overrides;
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvokeApi" /> class.
        /// </summary>
        public InvokeApi()
        {
        }
    }
}