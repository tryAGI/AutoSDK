//HintName: G.Models.OpenAIChatRequestMessageToolCall.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAIChatRequestMessageToolCall
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.OpenAIChatRequestMessageToolCallTypeJsonConverter))]
        public global::G.OpenAIChatRequestMessageToolCallType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("function", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OpenAIChatRequestMessageToolCallFunction Function { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIChatRequestMessageToolCall" /> class.
        /// </summary>
        /// <param name="function"></param>
        /// <param name="id"></param>
        /// <param name="type"></param>
        public OpenAIChatRequestMessageToolCall(
            global::G.OpenAIChatRequestMessageToolCallFunction function,
            string id,
            global::G.OpenAIChatRequestMessageToolCallType type)
        {
            this.Type = type;
            this.Function = function ?? throw new global::System.ArgumentNullException(nameof(function));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIChatRequestMessageToolCall" /> class.
        /// </summary>
        public OpenAIChatRequestMessageToolCall()
        {
        }
    }
}