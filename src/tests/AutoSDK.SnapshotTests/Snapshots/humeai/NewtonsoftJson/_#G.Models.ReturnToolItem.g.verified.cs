//HintName: G.Models.ReturnToolItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReturnToolItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_type")]
        public global::G.ReturnToolItemToolType? ToolType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version")]
        public int? Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnToolItem" /> class.
        /// </summary>
        /// <param name="toolType"></param>
        /// <param name="id"></param>
        /// <param name="version"></param>
        /// <param name="name"></param>
        public ReturnToolItem(
            global::G.ReturnToolItemToolType? toolType,
            string? id,
            int? version,
            string? name)
        {
            this.ToolType = toolType;
            this.Id = id;
            this.Version = version;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnToolItem" /> class.
        /// </summary>
        public ReturnToolItem()
        {
        }
    }
}