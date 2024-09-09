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
    }
}