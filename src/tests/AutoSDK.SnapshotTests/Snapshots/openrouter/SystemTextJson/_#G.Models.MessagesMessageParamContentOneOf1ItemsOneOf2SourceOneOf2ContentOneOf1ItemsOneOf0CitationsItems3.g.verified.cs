//HintName: G.Models.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1ItemsOneOf0CitationsItems3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1ItemsOneOf0CitationsItems3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1ItemsOneOf0CitationsItemsOneOf3TypeJsonConverter))]
        public global::G.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1ItemsOneOf0CitationsItemsOneOf3Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cited_text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CitedText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encrypted_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EncryptedIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

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
        /// Initializes a new instance of the <see cref="MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1ItemsOneOf0CitationsItems3" /> class.
        /// </summary>
        /// <param name="citedText"></param>
        /// <param name="encryptedIndex"></param>
        /// <param name="url"></param>
        /// <param name="type"></param>
        /// <param name="title"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1ItemsOneOf0CitationsItems3(
            string citedText,
            string encryptedIndex,
            string url,
            global::G.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1ItemsOneOf0CitationsItemsOneOf3Type type,
            string? title)
        {
            this.Type = type;
            this.CitedText = citedText ?? throw new global::System.ArgumentNullException(nameof(citedText));
            this.EncryptedIndex = encryptedIndex ?? throw new global::System.ArgumentNullException(nameof(encryptedIndex));
            this.Title = title;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1ItemsOneOf0CitationsItems3" /> class.
        /// </summary>
        public MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1ItemsOneOf0CitationsItems3()
        {
        }
    }
}