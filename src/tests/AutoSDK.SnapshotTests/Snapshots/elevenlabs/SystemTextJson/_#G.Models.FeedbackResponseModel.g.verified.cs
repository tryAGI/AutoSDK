//HintName: G.Models.FeedbackResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"audio_quality":true,"emotions":true,"feedback":"This is an example of test feedback.","glitches":true,"inaccurate_clone":false,"other":false,"review_status":"not_reviewed","thumbs_up":true}
    /// </summary>
    public sealed partial class FeedbackResponseModel
    {
        /// <summary>
        /// Whether the user liked the generated item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thumbs_up")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ThumbsUp { get; set; }

        /// <summary>
        /// The feedback text provided by the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Feedback { get; set; }

        /// <summary>
        /// Whether the user provided emotions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emotions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Emotions { get; set; }

        /// <summary>
        /// Whether the user thinks the clone is inaccurate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inaccurate_clone")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool InaccurateClone { get; set; }

        /// <summary>
        /// Whether the user thinks there are glitches in the audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("glitches")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Glitches { get; set; }

        /// <summary>
        /// Whether the user thinks the audio quality is good.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_quality")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AudioQuality { get; set; }

        /// <summary>
        /// Whether the user provided other feedback.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("other")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Other { get; set; }

        /// <summary>
        /// The review status of the item. Defaults to 'not_reviewed'.<br/>
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
        /// <param name="thumbsUp">
        /// Whether the user liked the generated item.
        /// </param>
        /// <param name="feedback">
        /// The feedback text provided by the user.
        /// </param>
        /// <param name="emotions">
        /// Whether the user provided emotions.
        /// </param>
        /// <param name="inaccurateClone">
        /// Whether the user thinks the clone is inaccurate.
        /// </param>
        /// <param name="glitches">
        /// Whether the user thinks there are glitches in the audio.
        /// </param>
        /// <param name="audioQuality">
        /// Whether the user thinks the audio quality is good.
        /// </param>
        /// <param name="other">
        /// Whether the user provided other feedback.
        /// </param>
        /// <param name="reviewStatus">
        /// The review status of the item. Defaults to 'not_reviewed'.<br/>
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