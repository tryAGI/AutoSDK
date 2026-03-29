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
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1Content Content { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("retrieved_at")]
        public string? RetrievedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1Type Type { get; set; }

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
        /// Initializes a new instance of the <see cref="BaseMessagesResultContentItemsOneOf6Content1" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="url"></param>
        /// <param name="retrievedAt"></param>
        /// <param name="type"></param>
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