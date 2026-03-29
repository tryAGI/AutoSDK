//HintName: G.Models.ObservationV2UsageDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The usage details of the observation. Key is the usage metric name, value is the number of units consumed.
    /// </summary>
    public sealed partial class ObservationV2UsageDetails
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}