//HintName: G.Models.CreatePredictionBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreatePredictionBody
    {
        /// <summary>
        /// The ID of the broadcaster that’s running the prediction. This ID must match the user ID in the user access token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("broadcaster_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BroadcasterId { get; set; }

        /// <summary>
        /// The question that the broadcaster is asking. For example, _Will I finish this entire pizza?_ The title is limited to a maximum of 45 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// The list of possible outcomes that the viewers may choose from. The list must contain a minimum of 2 choices and up to a maximum of 10 choices.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outcomes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.CreatePredictionBodyOutcome> Outcomes { get; set; }

        /// <summary>
        /// The length of time (in seconds) that the prediction will run for. The minimum is 30 seconds and the maximum is 1800 seconds (30 minutes).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prediction_window")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PredictionWindow { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePredictionBody" /> class.
        /// </summary>
        /// <param name="broadcasterId">
        /// The ID of the broadcaster that’s running the prediction. This ID must match the user ID in the user access token.
        /// </param>
        /// <param name="title">
        /// The question that the broadcaster is asking. For example, _Will I finish this entire pizza?_ The title is limited to a maximum of 45 characters.
        /// </param>
        /// <param name="outcomes">
        /// The list of possible outcomes that the viewers may choose from. The list must contain a minimum of 2 choices and up to a maximum of 10 choices.
        /// </param>
        /// <param name="predictionWindow">
        /// The length of time (in seconds) that the prediction will run for. The minimum is 30 seconds and the maximum is 1800 seconds (30 minutes).
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CreatePredictionBody(
            string broadcasterId,
            string title,
            global::System.Collections.Generic.IList<global::G.CreatePredictionBodyOutcome> outcomes,
            int predictionWindow)
        {
            this.BroadcasterId = broadcasterId ?? throw new global::System.ArgumentNullException(nameof(broadcasterId));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Outcomes = outcomes ?? throw new global::System.ArgumentNullException(nameof(outcomes));
            this.PredictionWindow = predictionWindow;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePredictionBody" /> class.
        /// </summary>
        public CreatePredictionBody()
        {
        }
    }
}