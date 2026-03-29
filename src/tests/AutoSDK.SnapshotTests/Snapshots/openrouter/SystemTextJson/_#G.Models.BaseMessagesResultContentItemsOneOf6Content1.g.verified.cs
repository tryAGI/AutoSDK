//HintName: G.Models.BaseMessagesResultContentItemsOneOf6Content1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BaseMessagesResultContentItemsOneOf6Content1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1Content Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retrieved_at")]
        public string? RetrievedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BaseMessagesResultContentItemsOneOf6ContentOneOf1TypeJsonConverter))]
        public global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResultContentItemsOneOf6Content1" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="url"></param>
        /// <param name="retrievedAt"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BaseMessagesResultContentItemsOneOf6Content1(
            global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1Content content,
            string url,
            string? retrievedAt,
            global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1Type type)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.RetrievedAt = retrievedAt;
            this.Type = type;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResultContentItemsOneOf6Content1" /> class.
        /// </summary>
        public BaseMessagesResultContentItemsOneOf6Content1()
        {
        }
    }
}