//HintName: G.Models.PredictionOutcomeTopPredictor.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PredictionOutcomeTopPredictor
    {
        /// <summary>
        /// An ID that identifies the viewer.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserId { get; set; } = default!;

        /// <summary>
        /// The viewer’s display name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserName { get; set; } = default!;

        /// <summary>
        /// The viewer’s login name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_login", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserLogin { get; set; } = default!;

        /// <summary>
        /// The number of Channel Points the viewer spent.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("channel_points_used", Required = global::Newtonsoft.Json.Required.Always)]
        public int ChannelPointsUsed { get; set; } = default!;

        /// <summary>
        /// The number of Channel Points distributed to the viewer.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("channel_points_won", Required = global::Newtonsoft.Json.Required.Always)]
        public int ChannelPointsWon { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}