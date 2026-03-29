//HintName: G.Models.PostToolRouterSessionBySessionIdSearchResponseToolSchemas2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostToolRouterSessionBySessionIdSearchResponseToolSchemas2
    {
        /// <summary>
        /// The slug of the toolkit that provides this tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolkit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Toolkit { get; set; }

        /// <summary>
        /// The slug of the tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolSlug { get; set; }

        /// <summary>
        /// Description of the tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Input schema for the tool (only present when hasFullSchema is true)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_schema")]
        public global::System.Collections.Generic.Dictionary<string, object?>? InputSchema { get; set; }

        /// <summary>
        /// Output/response schema for the tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_schema")]
        public global::System.Collections.Generic.Dictionary<string, object?>? OutputSchema { get; set; }

        /// <summary>
        /// Whether the full input_schema is included in this response
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hasFullSchema")]
        public bool? HasFullSchema { get; set; }

        /// <summary>
        /// Reference to fetch full schema when hasFullSchema is false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schemaRef")]
        public global::G.PostToolRouterSessionBySessionIdSearchResponseToolSchemasSchemaRef? SchemaRef { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdSearchResponseToolSchemas2" /> class.
        /// </summary>
        /// <param name="toolkit">
        /// The slug of the toolkit that provides this tool
        /// </param>
        /// <param name="toolSlug">
        /// The slug of the tool
        /// </param>
        /// <param name="description">
        /// Description of the tool
        /// </param>
        /// <param name="inputSchema">
        /// Input schema for the tool (only present when hasFullSchema is true)
        /// </param>
        /// <param name="outputSchema">
        /// Output/response schema for the tool
        /// </param>
        /// <param name="hasFullSchema">
        /// Whether the full input_schema is included in this response
        /// </param>
        /// <param name="schemaRef">
        /// Reference to fetch full schema when hasFullSchema is false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostToolRouterSessionBySessionIdSearchResponseToolSchemas2(
            string toolkit,
            string toolSlug,
            string? description,
            global::System.Collections.Generic.Dictionary<string, object?>? inputSchema,
            global::System.Collections.Generic.Dictionary<string, object?>? outputSchema,
            bool? hasFullSchema,
            global::G.PostToolRouterSessionBySessionIdSearchResponseToolSchemasSchemaRef? schemaRef)
        {
            this.Toolkit = toolkit ?? throw new global::System.ArgumentNullException(nameof(toolkit));
            this.ToolSlug = toolSlug ?? throw new global::System.ArgumentNullException(nameof(toolSlug));
            this.Description = description;
            this.InputSchema = inputSchema;
            this.OutputSchema = outputSchema;
            this.HasFullSchema = hasFullSchema;
            this.SchemaRef = schemaRef;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdSearchResponseToolSchemas2" /> class.
        /// </summary>
        public PostToolRouterSessionBySessionIdSearchResponseToolSchemas2()
        {
        }
    }
}