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
        [global::Newtonsoft.Json.JsonProperty("feedback", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.UserFeedbackScore Feedback { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodySendConversationFeedbackV1ConvaiConversationsConversationIdFeedbackPost" /> class.
        /// </summary>
        /// <param name="feedback"></param>
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