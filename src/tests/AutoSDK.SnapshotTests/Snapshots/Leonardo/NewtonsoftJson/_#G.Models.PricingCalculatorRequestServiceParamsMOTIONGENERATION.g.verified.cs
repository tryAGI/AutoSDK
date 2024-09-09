//HintName: G.Models.PricingCalculatorRequestServiceParamsMOTIONGENERATION.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parameters for MOTION_GENERATION service
    /// </summary>
    public sealed partial class PricingCalculatorRequestServiceParamsMOTIONGENERATION
    {
        /// <summary>
        /// The total duration of the motion generation in seconds.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("durationSeconds")]
        public int DurationSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}