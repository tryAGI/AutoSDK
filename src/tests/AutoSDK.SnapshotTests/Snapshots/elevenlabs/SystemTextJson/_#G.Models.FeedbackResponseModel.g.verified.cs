//HintName: G.Models.FeedbackResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FeedbackResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thumbs_up")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ThumbsUp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Feedback { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emotions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Emotions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inaccurate_clone")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool InaccurateClone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("glitches")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Glitches { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_quality")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AudioQuality { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("other")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Other { get; set; }

        /// <summary>
        /// Default Value: not_reviewed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("review_status")]
        public string? ReviewStatus { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackResponseModel" /> class.
        /// </summary>
        /// <param name="thumbsUp"></param>
        /// <param name="feedback"></param>
        /// <param name="emotions"></param>
        /// <param name="inaccurateClone"></param>
        /// <param name="glitches"></param>
        /// <param name="audioQuality"></param>
        /// <param name="other"></param>
        /// <param name="reviewStatus">
        /// Default Value: not_reviewed
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FeedbackResponseModel(
            bool thumbsUp,
            string feedback,
            bool emotions,
            bool inaccurateClone,
            bool glitches,
            bool audioQuality,
            bool other,
            string? reviewStatus)
        {
            this.ThumbsUp = thumbsUp;
            this.Feedback = feedback ?? throw new global::System.ArgumentNullException(nameof(feedback));
            this.Emotions = emotions;
            this.InaccurateClone = inaccurateClone;
            this.Glitches = glitches;
            this.AudioQuality = audioQuality;
            this.Other = other;
            this.ReviewStatus = reviewStatus;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackResponseModel" /> class.
        /// </summary>
        public FeedbackResponseModel()
        {
        }
    }
}