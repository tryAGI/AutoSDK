//HintName: G.Models.OutputItemReasoning.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OutputItemReasoning
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputItemReasoning" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="summary"></param>
        /// <param name="type"></param>
        /// <param name="content"></param>
        /// <param name="encryptedContent"></param>
        /// <param name="status"></param>
        public OutputItemReasoning(
            string id,
            global::System.Collections.Generic.IList<global::G.ReasoningSummaryText> summary,
            global::G.OutputItemReasoningType type,
            global::System.Collections.Generic.IList<global::G.ReasoningTextContent>? content,
            string? encryptedContent,
            global::G.OutputItemReasoningStatus? status)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Content = content;
            this.Summary = summary ?? throw new global::System.ArgumentNullException(nameof(summary));
            this.EncryptedContent = encryptedContent;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputItemReasoning" /> class.
        /// </summary>
        public OutputItemReasoning()
        {
        }
    }
}