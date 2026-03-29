//HintName: G.Models.NodeToolVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NodeToolVariant2
    {
        /// <summary>
        /// Unique identifier for the tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeToolVariant2" /> class.
        /// </summary>
        /// <param name="toolId">
        /// Unique identifier for the tool
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NodeToolVariant2(
            string toolId)
        {
            this.ToolId = toolId ?? throw new global::System.ArgumentNullException(nameof(toolId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeToolVariant2" /> class.
        /// </summary>
        public NodeToolVariant2()
        {
        }
    }
}