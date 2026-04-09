//HintName: G.Models.BaseMessagesResultContentItems1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BaseMessagesResultContentItems1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.BaseMessagesResultContentItemsOneOf1TypeJsonConverter))]
        public global::G.BaseMessagesResultContentItemsOneOf1Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("caller", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.BaseMessagesResultContentItemsOneOf1Caller Caller { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="BaseMessagesResultContentItems1" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="caller"></param>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="input"></param>
        public BaseMessagesResultContentItems1(
            string id,
            global::G.BaseMessagesResultContentItemsOneOf1Caller caller,
            string name,
            global::G.BaseMessagesResultContentItemsOneOf1Type type,
            object? input)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Caller = caller;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Input = input;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResultContentItems1" /> class.
        /// </summary>
        public BaseMessagesResultContentItems1()
        {
        }
    }
}