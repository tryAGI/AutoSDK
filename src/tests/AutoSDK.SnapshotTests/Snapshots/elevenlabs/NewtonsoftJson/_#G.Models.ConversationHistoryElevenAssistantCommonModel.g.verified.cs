//HintName: G.Models.ConversationHistoryElevenAssistantCommonModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationHistoryElevenAssistantCommonModel
    {
        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_eleven_assistant")]
        public bool? IsElevenAssistant { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryElevenAssistantCommonModel" /> class.
        /// </summary>
        /// <param name="isElevenAssistant">
        /// Default Value: false
        /// </param>
        public ConversationHistoryElevenAssistantCommonModel(
            bool? isElevenAssistant)
        {
            this.IsElevenAssistant = isElevenAssistant;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryElevenAssistantCommonModel" /> class.
        /// </summary>
        public ConversationHistoryElevenAssistantCommonModel()
        {
        }
    }
}