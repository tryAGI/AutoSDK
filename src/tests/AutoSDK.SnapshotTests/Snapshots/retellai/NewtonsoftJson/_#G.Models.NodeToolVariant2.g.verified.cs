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
        [global::Newtonsoft.Json.JsonProperty("tool_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ToolId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeToolVariant2" /> class.
        /// </summary>
        /// <param name="toolId">
        /// Unique identifier for the tool
        /// </param>
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