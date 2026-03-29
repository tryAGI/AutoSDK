//HintName: G.Models.ObservationUsageDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The usage details of the observation. Key is the name of the usage metric, value is the number of units consumed. The total key is the sum of all (non-total) usage metrics or the total value ingested.
    /// </summary>
    public sealed partial class ObservationUsageDetails
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}