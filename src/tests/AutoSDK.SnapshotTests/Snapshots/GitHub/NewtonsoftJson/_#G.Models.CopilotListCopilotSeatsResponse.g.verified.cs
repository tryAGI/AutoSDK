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
        [global::Newtonsoft.Json.JsonProperty("total_seats")]
        public int? TotalSeats { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("seats")]
        public global::System.Collections.Generic.IList<global::G.CopilotSeatDetails>? Seats { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotListCopilotSeatsResponse" /> class.
        /// </summary>
        /// <param name="totalSeats">
        /// Total number of Copilot seats for the organization currently being billed.
        /// </param>
        /// <param name="seats"></param>
        public CopilotListCopilotSeatsResponse(
            int? totalSeats,
            global::System.Collections.Generic.IList<global::G.CopilotSeatDetails>? seats)
        {
            this.TotalSeats = totalSeats;
            this.Seats = seats;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotListCopilotSeatsResponse" /> class.
        /// </summary>
        public CopilotListCopilotSeatsResponse()
        {
        }
    }
}