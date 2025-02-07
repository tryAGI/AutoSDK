//HintName: G.Models.Prediction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Prediction
    {
        /// <summary>
        /// An ID that identifies this prediction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// An ID that identifies the broadcaster that created the prediction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("broadcaster_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BroadcasterId { get; set; }

        /// <summary>
        /// The broadcaster’s display name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("broadcaster_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BroadcasterName { get; set; }

        /// <summary>
        /// The broadcaster’s login name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("broadcaster_login")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BroadcasterLogin { get; set; }

        /// <summary>
        /// The question that the prediction asks. For example, _Will I finish this entire pizza?_
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// The ID of the winning outcome. Is **null** unless `status` is RESOLVED.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("winning_outcome_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? WinningOutcomeId { get; set; }

        /// <summary>
        /// The list of possible outcomes for the prediction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outcomes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.PredictionOutcome> Outcomes { get; set; }

        /// <summary>
        /// The length of time (in seconds) that the prediction will run for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prediction_window")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PredictionWindow { get; set; }

        /// <summary>
        /// The prediction’s status. Valid values are:  <br/>
        ///   <br/>
        /// * ACTIVE — The Prediction is running and viewers can make predictions.<br/>
        /// * CANCELED — The broadcaster canceled the Prediction and refunded the Channel Points to the participants.<br/>
        /// * LOCKED — The broadcaster locked the Prediction, which means viewers can no longer make predictions.<br/>
        /// * RESOLVED — The winning outcome was determined and the Channel Points were distributed to the viewers who predicted the correct outcome.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PredictionStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PredictionStatus Status { get; set; }

        /// <summary>
        /// The UTC date and time of when the Prediction began.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The UTC date and time of when the Prediction ended. If `status` is ACTIVE, this is set to **null**.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ended_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime? EndedAt { get; set; }

        /// <summary>
        /// The UTC date and time of when the Prediction was locked. If `status` is not LOCKED, this is set to **null**.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("locked_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime? LockedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Prediction" /> class.
        /// </summary>
        /// <param name="id">
        /// An ID that identifies this prediction.
        /// </param>
        /// <param name="broadcasterId">
        /// An ID that identifies the broadcaster that created the prediction.
        /// </param>
        /// <param name="broadcasterName">
        /// The broadcaster’s display name.
        /// </param>
        /// <param name="broadcasterLogin">
        /// The broadcaster’s login name.
        /// </param>
        /// <param name="title">
        /// The question that the prediction asks. For example, _Will I finish this entire pizza?_
        /// </param>
        /// <param name="winningOutcomeId">
        /// The ID of the winning outcome. Is **null** unless `status` is RESOLVED.
        /// </param>
        /// <param name="outcomes">
        /// The list of possible outcomes for the prediction.
        /// </param>
        /// <param name="predictionWindow">
        /// The length of time (in seconds) that the prediction will run for.
        /// </param>
        /// <param name="status">
        /// The prediction’s status. Valid values are:  <br/>
        ///   <br/>
        /// * ACTIVE — The Prediction is running and viewers can make predictions.<br/>
        /// * CANCELED — The broadcaster canceled the Prediction and refunded the Channel Points to the participants.<br/>
        /// * LOCKED — The broadcaster locked the Prediction, which means viewers can no longer make predictions.<br/>
        /// * RESOLVED — The winning outcome was determined and the Channel Points were distributed to the viewers who predicted the correct outcome.
        /// </param>
        /// <param name="createdAt">
        /// The UTC date and time of when the Prediction began.
        /// </param>
        /// <param name="endedAt">
        /// The UTC date and time of when the Prediction ended. If `status` is ACTIVE, this is set to **null**.
        /// </param>
        /// <param name="lockedAt">
        /// The UTC date and time of when the Prediction was locked. If `status` is not LOCKED, this is set to **null**.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Prediction(
            string id,
            string broadcasterId,
            string broadcasterName,
            string broadcasterLogin,
            string title,
            string? winningOutcomeId,
            global::System.Collections.Generic.IList<global::G.PredictionOutcome> outcomes,
            int predictionWindow,
            global::G.PredictionStatus status,
            global::System.DateTime createdAt,
            global::System.DateTime? endedAt,
            global::System.DateTime? lockedAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.BroadcasterId = broadcasterId ?? throw new global::System.ArgumentNullException(nameof(broadcasterId));
            this.BroadcasterName = broadcasterName ?? throw new global::System.ArgumentNullException(nameof(broadcasterName));
            this.BroadcasterLogin = broadcasterLogin ?? throw new global::System.ArgumentNullException(nameof(broadcasterLogin));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.WinningOutcomeId = winningOutcomeId ?? throw new global::System.ArgumentNullException(nameof(winningOutcomeId));
            this.Outcomes = outcomes ?? throw new global::System.ArgumentNullException(nameof(outcomes));
            this.PredictionWindow = predictionWindow;
            this.Status = status;
            this.CreatedAt = createdAt;
            this.EndedAt = endedAt;
            this.LockedAt = lockedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Prediction" /> class.
        /// </summary>
        public Prediction()
        {
        }
    }
}