//HintName: G.Models.NodeBaseCommon.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NodeBaseCommon
    {
        /// <summary>
        /// Unique identifier for the node
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Optional name for display purposes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("global_node_setting")]
        public global::G.GlobalNodeSetting? GlobalNodeSetting { get; set; }

        /// <summary>
        /// Position for frontend display
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_position")]
        public global::G.NodeBaseCommonDisplayPosition? DisplayPosition { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeBaseCommon" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the node
        /// </param>
        /// <param name="name">
        /// Optional name for display purposes
        /// </param>
        /// <param name="globalNodeSetting"></param>
        /// <param name="displayPosition">
        /// Position for frontend display
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NodeBaseCommon(
            string id,
            string? name,
            global::G.GlobalNodeSetting? globalNodeSetting,
            global::G.NodeBaseCommonDisplayPosition? displayPosition)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name;
            this.GlobalNodeSetting = globalNodeSetting;
            this.DisplayPosition = displayPosition;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeBaseCommon" /> class.
        /// </summary>
        public NodeBaseCommon()
        {
        }
    }
}