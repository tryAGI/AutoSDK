//HintName: G.Models.ModifyFeedbackRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModifyFeedbackRequest
    {
        /// <summary>
        /// Whether this feedback is positive or negative
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback")]
        public global::G.FeedbackType? Feedback { get; set; }

        /// <summary>
        /// Feedback tags to add to the step
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyFeedbackRequest" /> class.
        /// </summary>
        /// <param name="feedback">
        /// Whether this feedback is positive or negative
        /// </param>
        /// <param name="tags">
        /// Feedback tags to add to the step
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModifyFeedbackRequest(
            global::G.FeedbackType? feedback,
            global::System.Collections.Generic.IList<string>? tags)
        {
            this.Feedback = feedback;
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyFeedbackRequest" /> class.
        /// </summary>
        public ModifyFeedbackRequest()
        {
        }
    }
}