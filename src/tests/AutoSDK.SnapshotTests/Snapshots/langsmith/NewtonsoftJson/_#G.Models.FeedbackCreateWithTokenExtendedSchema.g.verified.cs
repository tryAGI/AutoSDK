//HintName: G.Models.FeedbackCreateWithTokenExtendedSchema.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Feedback create schema with token.
    /// </summary>
    public sealed partial class FeedbackCreateWithTokenExtendedSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("score")]
        public global::G.AnyOf<double?, int?, bool?, object>? Score { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value")]
        public global::G.AnyOf<double?, int?, bool?, string, object>? Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("correction")]
        public global::G.AnyOf<object, string, object>? Correction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackCreateWithTokenExtendedSchema" /> class.
        /// </summary>
        /// <param name="score"></param>
        /// <param name="value"></param>
        /// <param name="comment"></param>
        /// <param name="correction"></param>
        /// <param name="metadata"></param>
        public FeedbackCreateWithTokenExtendedSchema(
            global::G.AnyOf<double?, int?, bool?, object>? score,
            global::G.AnyOf<double?, int?, bool?, string, object>? value,
            string? comment,
            global::G.AnyOf<object, string, object>? correction,
            object? metadata)
        {
            this.Score = score;
            this.Value = value;
            this.Comment = comment;
            this.Correction = correction;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackCreateWithTokenExtendedSchema" /> class.
        /// </summary>
        public FeedbackCreateWithTokenExtendedSchema()
        {
        }
    }
}