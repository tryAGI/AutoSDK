//HintName: G.Models.CopilotListCopilotSeatsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CopilotListCopilotSeatsResponse
    {
        /// <summary>
        /// Total number of Copilot seats for the organization currently being billed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_seats")]
        public int TotalSeats { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seats")]
        public global::System.Collections.Generic.IList<CopilotSeatDetails>? Seats { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}