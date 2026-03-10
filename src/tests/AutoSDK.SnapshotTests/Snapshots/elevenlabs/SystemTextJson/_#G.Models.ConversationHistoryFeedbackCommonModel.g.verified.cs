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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public global::G.ConversationFeedbackType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overall_score")]
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rating")]
        public int? Rating { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryFeedbackCommonModel" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="overallScore"></param>
        /// <param name="likes">
        /// Default Value: 0
        /// </param>
        /// <param name="dislikes">
        /// Default Value: 0
        /// </param>
        /// <param name="rating"></param>
        /// <param name="comment"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationHistoryFeedbackCommonModel(
            global::G.ConversationFeedbackType? type,
            global::G.UserFeedbackScore? overallScore,
            int? likes,
            int? dislikes,
            int? rating,
            string? comment)
        {
            this.Type = type;
            this.OverallScore = overallScore;
            this.Likes = likes;
            this.Dislikes = dislikes;
            this.Rating = rating;
            this.Comment = comment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryFeedbackCommonModel" /> class.
        /// </summary>
        public ConversationHistoryFeedbackCommonModel()
        {
        }
    }
}