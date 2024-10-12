//HintName: G.Models.CustomerVisiblePlanInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Customer visible plan information.
    /// </summary>
    public sealed partial class CustomerVisiblePlanInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tier", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PaymentPlanTier Tier { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("started_on", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime StartedOn { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ends_on")]
        public global::System.DateTime? EndsOn { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}