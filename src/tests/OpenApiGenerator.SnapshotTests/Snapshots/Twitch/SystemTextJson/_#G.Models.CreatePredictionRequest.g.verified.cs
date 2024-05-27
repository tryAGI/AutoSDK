//HintName: G.Models.CreatePredictionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreatePredictionRequest
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
        public required global::System.Collections.Generic.IList<CreatePredictionRequestOutcomes> Outcomes { get; set; }

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
    }
}