//HintName: G.Models.PostToolRouterSessionBySessionIdSearchResponseToolSchemasSchemaRef.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Reference to fetch full schema when hasFullSchema is false
    /// </summary>
    public sealed partial class PostToolRouterSessionBySessionIdSearchResponseToolSchemasSchemaRef
    {
        /// <summary>
        /// Tool to call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PostToolRouterSessionBySessionIdSearchResponseToolSchemasSchemaRefToolJsonConverter))]
        public global::G.PostToolRouterSessionBySessionIdSearchResponseToolSchemasSchemaRefTool Tool { get; set; }

        /// <summary>
        /// Arguments to pass to the tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("args")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PostToolRouterSessionBySessionIdSearchResponseToolSchemasSchemaRefArgs Args { get; set; }

        /// <summary>
        /// Instruction message for the LLM
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdSearchResponseToolSchemasSchemaRef" /> class.
        /// </summary>
        /// <param name="args">
        /// Arguments to pass to the tool
        /// </param>
        /// <param name="message">
        /// Instruction message for the LLM
        /// </param>
        /// <param name="tool">
        /// Tool to call
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostToolRouterSessionBySessionIdSearchResponseToolSchemasSchemaRef(
            global::G.PostToolRouterSessionBySessionIdSearchResponseToolSchemasSchemaRefArgs args,
            string message,
            global::G.PostToolRouterSessionBySessionIdSearchResponseToolSchemasSchemaRefTool tool)
        {
            this.Tool = tool;
            this.Args = args ?? throw new global::System.ArgumentNullException(nameof(args));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdSearchResponseToolSchemasSchemaRef" /> class.
        /// </summary>
        public PostToolRouterSessionBySessionIdSearchResponseToolSchemasSchemaRef()
        {
        }
    }
}