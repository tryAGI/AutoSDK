//HintName: G.Models.RelayTargetOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RelayTargetOptions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.RelayTargetOptionsTypeJsonConverter))]
        public global::G.RelayTargetOptionsType Type { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RelayTargetOptions" /> class.
        /// </summary>
        /// <param name="type"></param>
        public RelayTargetOptions(
            global::G.RelayTargetOptionsType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RelayTargetOptions" /> class.
        /// </summary>
        public RelayTargetOptions()
        {
        }
    }
}