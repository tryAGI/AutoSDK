//HintName: G.Models.EndPredictionBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EndPredictionBody
    {
        /// <summary>
        /// The ID of the broadcaster that’s running the prediction. This ID must match the user ID in the user access token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("broadcaster_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BroadcasterId { get; set; }

        /// <summary>
        /// The ID of the prediction to update.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The status to set the prediction to. Possible case-sensitive values are:  <br/>
        ///   <br/>
        /// * RESOLVED — The winning outcome is determined and the Channel Points are distributed to the viewers who predicted the correct outcome.<br/>
        /// * CANCELED — The broadcaster is canceling the prediction and sending refunds to the participants.<br/>
        /// * LOCKED — The broadcaster is locking the prediction, which means viewers may no longer make predictions.<br/>
        ///   <br/>
        /// The broadcaster can update an active prediction to LOCKED, RESOLVED, or CANCELED; and update a locked prediction to RESOLVED or CANCELED.  <br/>
        ///   <br/>
        /// The broadcaster has up to 24 hours after the prediction window closes to resolve the prediction. If not, Twitch sets the status to CANCELED and returns the points.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EndPredictionBodyStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.EndPredictionBodyStatus Status { get; set; }

        /// <summary>
        /// The ID of the winning outcome. You must set this parameter if you set `status` to RESOLVED.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("winning_outcome_id")]
        public string? WinningOutcomeId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EndPredictionBody" /> class.
        /// </summary>
        /// <param name="broadcasterId">
        /// The ID of the broadcaster that’s running the prediction. This ID must match the user ID in the user access token.
        /// </param>
        /// <param name="id">
        /// The ID of the prediction to update.
        /// </param>
        /// <param name="status">
        /// The status to set the prediction to. Possible case-sensitive values are:  <br/>
        ///   <br/>
        /// * RESOLVED — The winning outcome is determined and the Channel Points are distributed to the viewers who predicted the correct outcome.<br/>
        /// * CANCELED — The broadcaster is canceling the prediction and sending refunds to the participants.<br/>
        /// * LOCKED — The broadcaster is locking the prediction, which means viewers may no longer make predictions.<br/>
        ///   <br/>
        /// The broadcaster can update an active prediction to LOCKED, RESOLVED, or CANCELED; and update a locked prediction to RESOLVED or CANCELED.  <br/>
        ///   <br/>
        /// The broadcaster has up to 24 hours after the prediction window closes to resolve the prediction. If not, Twitch sets the status to CANCELED and returns the points.
        /// </param>
        /// <param name="winningOutcomeId">
        /// The ID of the winning outcome. You must set this parameter if you set `status` to RESOLVED.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public EndPredictionBody(
            string broadcasterId,
            string id,
            global::G.EndPredictionBodyStatus status,
            string? winningOutcomeId)
        {
            this.BroadcasterId = broadcasterId ?? throw new global::System.ArgumentNullException(nameof(broadcasterId));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Status = status;
            this.WinningOutcomeId = winningOutcomeId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EndPredictionBody" /> class.
        /// </summary>
        public EndPredictionBody()
        {
        }
    }
}