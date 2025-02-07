//HintName: G.Models.PredictionOutcome.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PredictionOutcome
    {
        /// <summary>
        /// An ID that identifies this outcome.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The outcome’s text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// The number of unique viewers that chose this outcome.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("users")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Users { get; set; }

        /// <summary>
        /// The number of Channel Points spent by viewers on this outcome.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel_points")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ChannelPoints { get; set; }

        /// <summary>
        /// A list of viewers who were the top predictors; otherwise, **null** if none.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_predictors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.PredictionOutcomeTopPredictor>? TopPredictors { get; set; }

        /// <summary>
        /// The color that visually identifies this outcome in the UX. Possible values are:  <br/>
        ///   <br/>
        /// * BLUE<br/>
        /// * PINK<br/>
        ///   <br/>
        /// If the number of outcomes is two, the color is BLUE for the first outcome and PINK for the second outcome. If there are more than two outcomes, the color is BLUE for all outcomes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PredictionOutcomeColorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PredictionOutcomeColor Color { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PredictionOutcome" /> class.
        /// </summary>
        /// <param name="id">
        /// An ID that identifies this outcome.
        /// </param>
        /// <param name="title">
        /// The outcome’s text.
        /// </param>
        /// <param name="users">
        /// The number of unique viewers that chose this outcome.
        /// </param>
        /// <param name="channelPoints">
        /// The number of Channel Points spent by viewers on this outcome.
        /// </param>
        /// <param name="topPredictors">
        /// A list of viewers who were the top predictors; otherwise, **null** if none.
        /// </param>
        /// <param name="color">
        /// The color that visually identifies this outcome in the UX. Possible values are:  <br/>
        ///   <br/>
        /// * BLUE<br/>
        /// * PINK<br/>
        ///   <br/>
        /// If the number of outcomes is two, the color is BLUE for the first outcome and PINK for the second outcome. If there are more than two outcomes, the color is BLUE for all outcomes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PredictionOutcome(
            string id,
            string title,
            int users,
            int channelPoints,
            global::System.Collections.Generic.IList<global::G.PredictionOutcomeTopPredictor>? topPredictors,
            global::G.PredictionOutcomeColor color)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Users = users;
            this.ChannelPoints = channelPoints;
            this.TopPredictors = topPredictors ?? throw new global::System.ArgumentNullException(nameof(topPredictors));
            this.Color = color;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PredictionOutcome" /> class.
        /// </summary>
        public PredictionOutcome()
        {
        }
    }
}