﻿//HintName: G.Models.CopilotListCopilotSeatsForEnterpriseResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CopilotListCopilotSeatsForEnterpriseResponse
    {
        /// <summary>
        /// The total number of Copilot seats the enterprise is being billed for. Users with access through multiple organizations or enterprise teams are only counted once.
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
        /// Initializes a new instance of the <see cref="CopilotListCopilotSeatsForEnterpriseResponse" /> class.
        /// </summary>
        /// <param name="totalSeats">
        /// The total number of Copilot seats the enterprise is being billed for. Users with access through multiple organizations or enterprise teams are only counted once.
        /// </param>
        /// <param name="seats"></param>
        public CopilotListCopilotSeatsForEnterpriseResponse(
            int? totalSeats,
            global::System.Collections.Generic.IList<global::G.CopilotSeatDetails>? seats)
        {
            this.TotalSeats = totalSeats;
            this.Seats = seats;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotListCopilotSeatsForEnterpriseResponse" /> class.
        /// </summary>
        public CopilotListCopilotSeatsForEnterpriseResponse()
        {
        }
    }
}