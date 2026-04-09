//HintName: G.Models.ReasoningItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Reasoning output item with signature and format extensions
    /// </summary>
    public sealed partial class ReasoningItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.OutputItemReasoningTypeJsonConverter))]
        public global::G.OutputItemReasoningType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content")]
        public global::System.Collections.Generic.IList<global::G.ReasoningTextContent>? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ReasoningSummaryText> Summary { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("encrypted_content")]
        public string? EncryptedContent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.OutputItemReasoningStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("signature")]
        public string? Signature { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("format")]
        public global::G.OneOf<global::G.ReasoningItemFormat?, object>? Format { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningItem" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="summary"></param>
        /// <param name="type"></param>
        /// <param name="content"></param>
        /// <param name="encryptedContent"></param>
        /// <param name="status"></param>
        /// <param name="signature"></param>
        /// <param name="format"></param>
        public ReasoningItem(
            string id,
            global::System.Collections.Generic.IList<global::G.ReasoningSummaryText> summary,
            global::G.OutputItemReasoningType type,
            global::System.Collections.Generic.IList<global::G.ReasoningTextContent>? content,
            string? encryptedContent,
            global::G.OutputItemReasoningStatus? status,
            string? signature,
            global::G.OneOf<global::G.ReasoningItemFormat?, object>? format)
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
        /// Initializes a new instance of the <see cref="ReasoningItem" /> class.
        /// </summary>
        public ReasoningItem()
        {
        }
    }
}