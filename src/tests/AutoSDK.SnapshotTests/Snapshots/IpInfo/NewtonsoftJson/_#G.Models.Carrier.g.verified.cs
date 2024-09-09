//HintName: G.Models.Carrier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Carrier
    {
        /// <summary>
        /// Example: Sprint Corporation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Example: 310
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mcc", Required = global::Newtonsoft.Json.Required.Always)]
        public string Mcc { get; set; } = default!;

        /// <summary>
        /// Example: 120
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mnc", Required = global::Newtonsoft.Json.Required.Always)]
        public string Mnc { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}