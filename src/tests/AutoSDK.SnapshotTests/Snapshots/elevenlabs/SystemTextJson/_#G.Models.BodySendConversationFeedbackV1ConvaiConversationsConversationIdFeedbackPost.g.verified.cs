//HintName: G.Models.BodySendConversationFeedbackV1ConvaiConversationsConversationIdFeedbackPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodySendConversationFeedbackV1ConvaiConversationsConversationIdFeedbackPost
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UserFeedbackScoreJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.UserFeedbackScore Feedback { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodySendConversationFeedbackV1ConvaiConversationsConversationIdFeedbackPost" /> class.
        /// </summary>
        /// <param name="feedback"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodySendConversationFeedbackV1ConvaiConversationsConversationIdFeedbackPost(
            global::G.UserFeedbackScore feedback)
        {
            this.Feedback = feedback;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodySendConversationFeedbackV1ConvaiConversationsConversationIdFeedbackPost" /> class.
        /// </summary>
        public BodySendConversationFeedbackV1ConvaiConversationsConversationIdFeedbackPost()
        {
        }
    }
}