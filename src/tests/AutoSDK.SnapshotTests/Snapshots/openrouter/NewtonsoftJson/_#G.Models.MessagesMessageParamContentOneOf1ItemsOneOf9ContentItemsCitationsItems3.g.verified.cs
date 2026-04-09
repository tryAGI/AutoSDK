//HintName: G.Models.MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsCitationsItems3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsCitationsItems3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsCitationsItemsOneOf3TypeJsonConverter))]
        public global::G.MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsCitationsItemsOneOf3Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cited_text", Required = global::Newtonsoft.Json.Required.Always)]
        public string CitedText { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("encrypted_index", Required = global::Newtonsoft.Json.Required.Always)]
        public string EncryptedIndex { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsCitationsItems3" /> class.
        /// </summary>
        /// <param name="citedText"></param>
        /// <param name="encryptedIndex"></param>
        /// <param name="url"></param>
        /// <param name="type"></param>
        /// <param name="title"></param>
        public MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsCitationsItems3(
            string citedText,
            string encryptedIndex,
            string url,
            global::G.MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsCitationsItemsOneOf3Type type,
            string? title)
        {
            this.Type = type;
            this.CitedText = citedText ?? throw new global::System.ArgumentNullException(nameof(citedText));
            this.EncryptedIndex = encryptedIndex ?? throw new global::System.ArgumentNullException(nameof(encryptedIndex));
            this.Title = title;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsCitationsItems3" /> class.
        /// </summary>
        public MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsCitationsItems3()
        {
        }
    }
}