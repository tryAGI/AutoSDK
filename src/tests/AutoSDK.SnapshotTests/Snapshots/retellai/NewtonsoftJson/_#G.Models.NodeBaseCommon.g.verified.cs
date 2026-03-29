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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Optional name for display purposes
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("global_node_setting")]
        public global::G.GlobalNodeSetting? GlobalNodeSetting { get; set; }

        /// <summary>
        /// Position for frontend display
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("display_position")]
        public global::G.NodeBaseCommonDisplayPosition? DisplayPosition { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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