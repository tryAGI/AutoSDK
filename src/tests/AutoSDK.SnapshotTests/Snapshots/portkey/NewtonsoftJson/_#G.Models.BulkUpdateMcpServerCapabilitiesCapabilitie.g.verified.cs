//HintName: G.Models.BulkUpdateMcpServerCapabilitiesCapabilitie.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BulkUpdateMcpServerCapabilitiesCapabilitie
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.BulkUpdateMcpServerCapabilitiesCapabilitieTypeJsonConverter))]
        public global::G.BulkUpdateMcpServerCapabilitiesCapabilitieType Type { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Enabled { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateMcpServerCapabilitiesCapabilitie" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="enabled"></param>
        public BulkUpdateMcpServerCapabilitiesCapabilitie(
            string name,
            global::G.BulkUpdateMcpServerCapabilitiesCapabilitieType type,
            bool enabled)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateMcpServerCapabilitiesCapabilitie" /> class.
        /// </summary>
        public BulkUpdateMcpServerCapabilitiesCapabilitie()
        {
        }
    }
}