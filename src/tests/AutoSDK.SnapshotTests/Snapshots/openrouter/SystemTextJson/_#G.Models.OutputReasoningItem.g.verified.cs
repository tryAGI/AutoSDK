//HintName: G.Models.OutputReasoningItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An output item containing reasoning
    /// </summary>
    public sealed partial class OutputReasoningItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OutputItemReasoningTypeJsonConverter))]
        public global::G.OutputItemReasoningType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::System.Collections.Generic.IList<global::G.ReasoningTextContent>? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ReasoningSummaryText> Summary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encrypted_content")]
        public string? EncryptedContent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OutputItemReasoningStatusJsonConverter))]
        public global::G.OutputItemReasoningStatus? Status { get; set; }

        /// <summary>
        /// A signature for the reasoning content, used for verification
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signature")]
        public string? Signature { get; set; }

        /// <summary>
        /// The format of the reasoning content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.OutputReasoningItemFormat?, object>))]
        public global::G.OneOf<global::G.OutputReasoningItemFormat?, object>? Format { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputReasoningItem" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="summary"></param>
        /// <param name="type"></param>
        /// <param name="content"></param>
        /// <param name="encryptedContent"></param>
        /// <param name="status"></param>
        /// <param name="signature">
        /// A signature for the reasoning content, used for verification
        /// </param>
        /// <param name="format">
        /// The format of the reasoning content
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputReasoningItem(
            string id,
            global::System.Collections.Generic.IList<global::G.ReasoningSummaryText> summary,
            global::G.OutputItemReasoningType type,
            global::System.Collections.Generic.IList<global::G.ReasoningTextContent>? content,
            string? encryptedContent,
            global::G.OutputItemReasoningStatus? status,
            string? signature,
            global::G.OneOf<global::G.OutputReasoningItemFormat?, object>? format)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Content = content;
            this.Summary = summary ?? throw new global::System.ArgumentNullException(nameof(summary));
            this.EncryptedContent = encryptedContent;
            this.Status = status;
            this.Signature = signature;
            this.Format = format;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputReasoningItem" /> class.
        /// </summary>
        public OutputReasoningItem()
        {
        }
    }
}