//HintName: G.Models.McpToolsResponse200.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class McpToolsResponse200
    {
        /// <summary>
        /// Type of object (list).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// The available mcp tools.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::G.McpToolsGetResponsesContentApplicationJsonSchemaDataItems>>? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpToolsResponse200" /> class.
        /// </summary>
        /// <param name="object">
        /// Type of object (list).
        /// </param>
        /// <param name="data">
        /// The available mcp tools.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public McpToolsResponse200(
            string? @object,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::G.McpToolsGetResponsesContentApplicationJsonSchemaDataItems>>? data)
        {
            this.Object = @object;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpToolsResponse200" /> class.
        /// </summary>
        public McpToolsResponse200()
        {
        }
    }
}