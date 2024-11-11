//HintName: G.Models.CopilotAddCopilotSeatsForTeamsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The total number of seat assignments created.
    /// </summary>
    public sealed partial class CopilotAddCopilotSeatsForTeamsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seats_created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SeatsCreated { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotAddCopilotSeatsForTeamsResponse" /> class.
        /// </summary>
        /// <param name="seatsCreated"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CopilotAddCopilotSeatsForTeamsResponse(
            int seatsCreated)
        {
            this.SeatsCreated = seatsCreated;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotAddCopilotSeatsForTeamsResponse" /> class.
        /// </summary>
        public CopilotAddCopilotSeatsForTeamsResponse()
        {
        }
    }
}