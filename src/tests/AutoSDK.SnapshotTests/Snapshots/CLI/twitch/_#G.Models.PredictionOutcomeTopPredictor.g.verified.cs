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

        /// <summary>
        /// Initializes a new instance of the <see cref="PredictionOutcomeTopPredictor" /> class.
        /// </summary>
        /// <param name="userId">
        /// An ID that identifies the viewer.
        /// </param>
        /// <param name="userName">
        /// The viewer’s display name.
        /// </param>
        /// <param name="userLogin">
        /// The viewer’s login name.
        /// </param>
        /// <param name="channelPointsUsed">
        /// The number of Channel Points the viewer spent.
        /// </param>
        /// <param name="channelPointsWon">
        /// The number of Channel Points distributed to the viewer.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PredictionOutcomeTopPredictor(
            string userId,
            string userName,
            string userLogin,
            int channelPointsUsed,
            int channelPointsWon)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.UserName = userName ?? throw new global::System.ArgumentNullException(nameof(userName));
            this.UserLogin = userLogin ?? throw new global::System.ArgumentNullException(nameof(userLogin));
            this.ChannelPointsUsed = channelPointsUsed;
            this.ChannelPointsWon = channelPointsWon;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PredictionOutcomeTopPredictor" /> class.
        /// </summary>
        public PredictionOutcomeTopPredictor()
        {
        }
    }
}