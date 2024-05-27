//HintName: G.Models.PredictionOutcomeTopPredictors.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PredictionOutcomeTopPredictors
    {
        /// <summary>
        /// An ID that identifies the viewer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// The viewer’s display name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserName { get; set; }

        /// <summary>
        /// The viewer’s login name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_login")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserLogin { get; set; }

        /// <summary>
        /// The number of Channel Points the viewer spent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel_points_used")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ChannelPointsUsed { get; set; }

        /// <summary>
        /// The number of Channel Points distributed to the viewer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel_points_won")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ChannelPointsWon { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}