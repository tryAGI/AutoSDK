//HintName: G.Models.ObservationV2CostDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The cost details of the observation. Key is the cost metric name, value is the cost in USD.
    /// </summary>
    public sealed partial class ObservationV2CostDetails
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}