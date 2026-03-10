//HintName: G.Models.ConversationHistoryMultivoiceMessageModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents a message from a multi-voice agent.
    /// </summary>
    public sealed partial class ConversationHistoryMultivoiceMessageModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parts", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ConversationHistoryMultivoiceMessagePartModel> Parts { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryMultivoiceMessageModel" /> class.
        /// </summary>
        /// <param name="parts"></param>
        public ConversationHistoryMultivoiceMessageModel(
            global::System.Collections.Generic.IList<global::G.ConversationHistoryMultivoiceMessagePartModel> parts)
        {
            this.Parts = parts ?? throw new global::System.ArgumentNullException(nameof(parts));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryMultivoiceMessageModel" /> class.
        /// </summary>
        public ConversationHistoryMultivoiceMessageModel()
        {
        }
    }
}