//HintName: G.Models.FeedbackSchema.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Schema for getting feedback.
    /// </summary>
    public sealed partial class FeedbackSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modified_at")]
        public global::System.DateTime? ModifiedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<double?, int?, bool?>))]
        public global::G.AnyOf<double?, int?, bool?>? Score { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, string, object>))]
        public global::G.AnyOf<double?, int?, bool?, string, object>? Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("correction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<object, string>))]
        public global::G.AnyOf<object, string>? Correction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback_group_id")]
        public global::System.Guid? FeedbackGroupId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comparative_experiment_id")]
        public global::System.Guid? ComparativeExperimentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_id")]
        public global::System.Guid? RunId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public global::System.Guid? SessionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// The feedback source loaded from the database.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback_source")]
        public global::G.FeedbackSource3? FeedbackSource { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackSchema" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="modifiedAt"></param>
        /// <param name="key"></param>
        /// <param name="score"></param>
        /// <param name="value"></param>
        /// <param name="comment"></param>
        /// <param name="correction"></param>
        /// <param name="feedbackGroupId"></param>
        /// <param name="comparativeExperimentId"></param>
        /// <param name="runId"></param>
        /// <param name="sessionId"></param>
        /// <param name="id"></param>
        /// <param name="feedbackSource">
        /// The feedback source loaded from the database.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public FeedbackSchema(
            string key,
            global::System.Guid id,
            global::System.DateTime? createdAt,
            global::System.DateTime? modifiedAt,
            global::G.AnyOf<double?, int?, bool?>? score,
            global::G.AnyOf<double?, int?, bool?, string, object>? value,
            string? comment,
            global::G.AnyOf<object, string>? correction,
            global::System.Guid? feedbackGroupId,
            global::System.Guid? comparativeExperimentId,
            global::System.Guid? runId,
            global::System.Guid? sessionId,
            global::G.FeedbackSource3? feedbackSource)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Id = id;
            this.CreatedAt = createdAt;
            this.ModifiedAt = modifiedAt;
            this.Score = score;
            this.Value = value;
            this.Comment = comment;
            this.Correction = correction;
            this.FeedbackGroupId = feedbackGroupId;
            this.ComparativeExperimentId = comparativeExperimentId;
            this.RunId = runId;
            this.SessionId = sessionId;
            this.FeedbackSource = feedbackSource;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackSchema" /> class.
        /// </summary>
        public FeedbackSchema()
        {
        }
    }
}