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
        [global::Newtonsoft.Json.JsonProperty("tool")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PostToolRouterSessionBySessionIdSearchResponseToolSchemasSchemaRefToolJsonConverter))]
        public global::G.PostToolRouterSessionBySessionIdSearchResponseToolSchemasSchemaRefTool Tool { get; set; }

        /// <summary>
        /// Arguments to pass to the tool
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("args", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PostToolRouterSessionBySessionIdSearchResponseToolSchemasSchemaRefArgs Args { get; set; } = default!;

        /// <summary>
        /// Instruction message for the LLM
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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