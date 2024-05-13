//HintName: G.Models.RunObjectIncompleteDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Details on why the run is incomplete. Will be `null` if the run is not incomplete.
    /// </summary>
    public sealed partial class RunObjectIncompleteDetails
    {
        /// <summary>
        /// The reason why the run is incomplete. This will point to which specific token limit was reached over the course of the run.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reason")]
        public RunObjectIncompleteDetailsReason? Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}