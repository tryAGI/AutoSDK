//HintName: G.Models.PostToolRouterSessionBySessionIdSearchResponseToolSchemasSchemaRefArgs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Arguments to pass to the tool
    /// </summary>
    public sealed partial class PostToolRouterSessionBySessionIdSearchResponseToolSchemasSchemaRefArgs
    {
        /// <summary>
        /// Tool slugs to fetch schemas for
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_slugs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ToolSlugs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdSearchResponseToolSchemasSchemaRefArgs" /> class.
        /// </summary>
        /// <param name="toolSlugs">
        /// Tool slugs to fetch schemas for
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostToolRouterSessionBySessionIdSearchResponseToolSchemasSchemaRefArgs(
            global::System.Collections.Generic.IList<string> toolSlugs)
        {
            this.ToolSlugs = toolSlugs ?? throw new global::System.ArgumentNullException(nameof(toolSlugs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdSearchResponseToolSchemasSchemaRefArgs" /> class.
        /// </summary>
        public PostToolRouterSessionBySessionIdSearchResponseToolSchemasSchemaRefArgs()
        {
        }
    }
}