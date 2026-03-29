//HintName: G.Models.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public string Data { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("media_type")]
        public global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf0MediaType MediaType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf0Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="mediaType"></param>
        /// <param name="type"></param>
        public BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0(
            string data,
            global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf0MediaType mediaType,
            global::G.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf0Type type)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.MediaType = mediaType;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0" /> class.
        /// </summary>
        public BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0()
        {
        }
    }
}