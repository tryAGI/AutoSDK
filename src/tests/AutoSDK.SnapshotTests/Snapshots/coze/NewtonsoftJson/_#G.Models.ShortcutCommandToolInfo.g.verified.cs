//HintName: G.Models.ShortcutCommandToolInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ShortcutCommandToolInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// tool类型 workflow plugin
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ShortcutCommandToolInfo" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type">
        /// tool类型 workflow plugin
        /// </param>
        public ShortcutCommandToolInfo(
            string? name,
            string? type)
        {
            this.Name = name;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShortcutCommandToolInfo" /> class.
        /// </summary>
        public ShortcutCommandToolInfo()
        {
        }
    }
}