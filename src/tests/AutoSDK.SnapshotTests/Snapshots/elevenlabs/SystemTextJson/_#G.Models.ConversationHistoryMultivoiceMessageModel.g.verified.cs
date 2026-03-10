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
        [global::System.Text.Json.Serialization.JsonPropertyName("parts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ConversationHistoryMultivoiceMessagePartModel> Parts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryMultivoiceMessageModel" /> class.
        /// </summary>
        /// <param name="parts"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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