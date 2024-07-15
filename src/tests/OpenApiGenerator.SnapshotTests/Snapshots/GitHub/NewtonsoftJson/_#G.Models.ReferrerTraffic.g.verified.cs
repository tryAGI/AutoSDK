//HintName: G.Models.ReferrerTraffic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Referrer Traffic
    /// </summary>
    public sealed partial class ReferrerTraffic
    {
        /// <summary>
        /// Example: Google
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("referrer", Required = global::Newtonsoft.Json.Required.Always)]
        public string Referrer { get; set; } = default!;

        /// <summary>
        /// Example: 4
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("count", Required = global::Newtonsoft.Json.Required.Always)]
        public int Count { get; set; } = default!;

        /// <summary>
        /// Example: 3
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("uniques", Required = global::Newtonsoft.Json.Required.Always)]
        public int Uniques { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}