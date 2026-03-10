//HintName: G.Models.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1Discriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1Discriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result_type")]
        public global::G.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType? ResultType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1Discriminator" /> class.
        /// </summary>
        /// <param name="resultType"></param>
        public ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1Discriminator(
            global::G.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType? resultType)
        {
            this.ResultType = resultType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1Discriminator" /> class.
        /// </summary>
        public ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1Discriminator()
        {
        }
    }
}