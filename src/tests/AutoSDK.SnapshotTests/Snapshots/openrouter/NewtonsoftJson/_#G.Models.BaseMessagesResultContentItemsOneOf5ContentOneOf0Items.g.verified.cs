//HintName: G.Models.BaseMessagesResultContentItemsOneOf5ContentOneOf0Items.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BaseMessagesResultContentItemsOneOf5ContentOneOf0Items
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.BaseMessagesResultContentItemsOneOf5ContentOneOf0ItemsType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("encrypted_content", Required = global::Newtonsoft.Json.Required.Always)]
        public string EncryptedContent { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page_age")]
        public string? PageAge { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="BaseMessagesResultContentItemsOneOf5ContentOneOf0Items" /> class.
        /// </summary>
        /// <param name="encryptedContent"></param>
        /// <param name="title"></param>
        /// <param name="url"></param>
        /// <param name="type"></param>
        /// <param name="pageAge"></param>
        public BaseMessagesResultContentItemsOneOf5ContentOneOf0Items(
            string encryptedContent,
            string title,
            string url,
            global::G.BaseMessagesResultContentItemsOneOf5ContentOneOf0ItemsType type,
            string? pageAge)
        {
            this.Type = type;
            this.EncryptedContent = encryptedContent ?? throw new global::System.ArgumentNullException(nameof(encryptedContent));
            this.PageAge = pageAge;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResultContentItemsOneOf5ContentOneOf0Items" /> class.
        /// </summary>
        public BaseMessagesResultContentItemsOneOf5ContentOneOf0Items()
        {
        }
    }
}