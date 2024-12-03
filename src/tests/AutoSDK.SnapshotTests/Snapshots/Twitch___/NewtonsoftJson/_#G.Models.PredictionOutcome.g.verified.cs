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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The outcome’s text.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// The number of unique viewers that chose this outcome.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("users", Required = global::Newtonsoft.Json.Required.Always)]
        public int Users { get; set; } = default!;

        /// <summary>
        /// The number of Channel Points spent by viewers on this outcome.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("channel_points", Required = global::Newtonsoft.Json.Required.Always)]
        public int ChannelPoints { get; set; } = default!;

        /// <summary>
        /// A list of viewers who were the top predictors; otherwise, **null** if none.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("top_predictors", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.PredictionOutcomeTopPredictor>? TopPredictors { get; set; } = default!;

        /// <summary>
        /// The color that visually identifies this outcome in the UX. Possible values are:  <br/>
        ///   <br/>
        /// * BLUE<br/>
        /// * PINK<br/>
        ///   <br/>
        /// If the number of outcomes is two, the color is BLUE for the first outcome and PINK for the second outcome. If there are more than two outcomes, the color is BLUE for all outcomes.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("color", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PredictionOutcomeColor Color { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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