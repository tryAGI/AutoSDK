//HintName: G.Models.ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1Discriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1Discriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result_type")]
        public global::G.ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType? ResultType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1Discriminator" /> class.
        /// </summary>
        /// <param name="resultType"></param>
        public ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1Discriminator(
            global::G.ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType? resultType)
        {
            this.ResultType = resultType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1Discriminator" /> class.
        /// </summary>
        public ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1Discriminator()
        {
        }
    }
}