//HintName: G.Models.ConversationFeedbackRequestModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationFeedbackRequestModel
    {
        /// <summary>
        /// Either 'like' or 'dislike' to indicate the feedback for the conversation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("feedback")]
        public global::G.UserFeedbackScore? Feedback { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationFeedbackRequestModel" /> class.
        /// </summary>
        /// <param name="feedback">
        /// Either 'like' or 'dislike' to indicate the feedback for the conversation.
        /// </param>
        public ConversationFeedbackRequestModel(
            global::G.UserFeedbackScore? feedback)
        {
            this.Feedback = feedback;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationFeedbackRequestModel" /> class.
        /// </summary>
        public ConversationFeedbackRequestModel()
        {
        }
    }
}