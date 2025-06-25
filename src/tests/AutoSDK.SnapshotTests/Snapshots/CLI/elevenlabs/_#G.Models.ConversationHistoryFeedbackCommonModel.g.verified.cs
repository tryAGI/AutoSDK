//HintName: G.Models.ConversationHistoryFeedbackCommonModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationHistoryFeedbackCommonModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overall_score")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UserFeedbackScoreJsonConverter))]
        public global::G.UserFeedbackScore? OverallScore { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("likes")]
        public int? Likes { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dislikes")]
        public int? Dislikes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryFeedbackCommonModel" /> class.
        /// </summary>
        /// <param name="overallScore"></param>
        /// <param name="likes">
        /// Default Value: 0
        /// </param>
        /// <param name="dislikes">
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationHistoryFeedbackCommonModel(
            global::G.UserFeedbackScore? overallScore,
            int? likes,
            int? dislikes)
        {
            this.OverallScore = overallScore;
            this.Likes = likes;
            this.Dislikes = dislikes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryFeedbackCommonModel" /> class.
        /// </summary>
        public ConversationHistoryFeedbackCommonModel()
        {
        }
    }
}