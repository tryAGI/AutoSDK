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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// An ID that identifies the broadcaster that created the prediction.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("broadcaster_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string BroadcasterId { get; set; } = default!;

        /// <summary>
        /// The broadcaster’s display name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("broadcaster_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string BroadcasterName { get; set; } = default!;

        /// <summary>
        /// The broadcaster’s login name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("broadcaster_login", Required = global::Newtonsoft.Json.Required.Always)]
        public string BroadcasterLogin { get; set; } = default!;

        /// <summary>
        /// The question that the prediction asks. For example, _Will I finish this entire pizza?_
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// The ID of the winning outcome. Is **null** unless `status` is RESOLVED.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("winning_outcome_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string? WinningOutcomeId { get; set; } = default!;

        /// <summary>
        /// The list of possible outcomes for the prediction.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("outcomes", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.PredictionOutcome> Outcomes { get; set; } = default!;

        /// <summary>
        /// The length of time (in seconds) that the prediction will run for.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prediction_window", Required = global::Newtonsoft.Json.Required.Always)]
        public int PredictionWindow { get; set; } = default!;

        /// <summary>
        /// The prediction’s status. Valid values are:  <br/>
        ///   <br/>
        /// * ACTIVE — The Prediction is running and viewers can make predictions.<br/>
        /// * CANCELED — The broadcaster canceled the Prediction and refunded the Channel Points to the participants.<br/>
        /// * LOCKED — The broadcaster locked the Prediction, which means viewers can no longer make predictions.<br/>
        /// * RESOLVED — The winning outcome was determined and the Channel Points were distributed to the viewers who predicted the correct outcome.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PredictionStatus Status { get; set; } = default!;

        /// <summary>
        /// The UTC date and time of when the Prediction began.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// The UTC date and time of when the Prediction ended. If `status` is ACTIVE, this is set to **null**.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ended_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? EndedAt { get; set; } = default!;

        /// <summary>
        /// The UTC date and time of when the Prediction was locked. If `status` is not LOCKED, this is set to **null**.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("locked_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? LockedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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