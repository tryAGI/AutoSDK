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
        [global::System.Text.Json.Serialization.JsonPropertyName("seats_cancelled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SeatsCancelled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotCancelCopilotSeatAssignmentForTeamsResponse" /> class.
        /// </summary>
        /// <param name="seatsCancelled"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CopilotCancelCopilotSeatAssignmentForTeamsResponse(
            int seatsCancelled)
        {
            this.SeatsCancelled = seatsCancelled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotCancelCopilotSeatAssignmentForTeamsResponse" /> class.
        /// </summary>
        public CopilotCancelCopilotSeatAssignmentForTeamsResponse()
        {
        }
    }
}