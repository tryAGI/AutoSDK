//HintName: G.Models.BaseMessagesResultContentItems4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BaseMessagesResultContentItems4
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.BaseMessagesResultContentItemsOneOf4TypeJsonConverter))]
        public global::G.BaseMessagesResultContentItemsOneOf4Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("caller", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.BaseMessagesResultContentItemsOneOf4Caller Caller { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.BaseMessagesResultContentItemsOneOf4NameJsonConverter))]
        public global::G.BaseMessagesResultContentItemsOneOf4Name Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input")]
        public object? Input { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResultContentItems4" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="caller"></param>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="input"></param>
        public BaseMessagesResultContentItems4(
            string id,
            global::G.BaseMessagesResultContentItemsOneOf4Caller caller,
            global::G.BaseMessagesResultContentItemsOneOf4Name name,
            global::G.BaseMessagesResultContentItemsOneOf4Type type,
            object? input)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Caller = caller;
            this.Name = name;
            this.Input = input;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResultContentItems4" /> class.
        /// </summary>
        public BaseMessagesResultContentItems4()
        {
        }
    }
}