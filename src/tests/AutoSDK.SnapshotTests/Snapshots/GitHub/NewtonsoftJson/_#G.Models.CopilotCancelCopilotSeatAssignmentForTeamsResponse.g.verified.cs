//HintName: G.Models.CopilotCancelCopilotSeatAssignmentForTeamsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The total number of seat assignments cancelled.
    /// </summary>
    public sealed partial class CopilotCancelCopilotSeatAssignmentForTeamsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("seats_cancelled", Required = global::Newtonsoft.Json.Required.Always)]
        public int SeatsCancelled { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}