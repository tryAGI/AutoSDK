//HintName: G.Models.MessagesMessageParamContentOneOf1Items7.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessagesMessageParamContentOneOf1Items7
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf7TypeJsonConverter))]
        public global::G.MessagesMessageParamContentOneOf1ItemsOneOf7Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf7NameJsonConverter))]
        public global::G.MessagesMessageParamContentOneOf1ItemsOneOf7Name Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input")]
        public object? Input { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cache_control")]
        public global::G.MessagesMessageParamContentOneOf1ItemsOneOf7CacheControl? CacheControl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesMessageParamContentOneOf1Items7" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="input"></param>
        /// <param name="cacheControl"></param>
        public MessagesMessageParamContentOneOf1Items7(
            string id,
            global::G.MessagesMessageParamContentOneOf1ItemsOneOf7Name name,
            global::G.MessagesMessageParamContentOneOf1ItemsOneOf7Type type,
            object? input,
            global::G.MessagesMessageParamContentOneOf1ItemsOneOf7CacheControl? cacheControl)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name;
            this.Input = input;
            this.CacheControl = cacheControl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesMessageParamContentOneOf1Items7" /> class.
        /// </summary>
        public MessagesMessageParamContentOneOf1Items7()
        {
        }
    }
}