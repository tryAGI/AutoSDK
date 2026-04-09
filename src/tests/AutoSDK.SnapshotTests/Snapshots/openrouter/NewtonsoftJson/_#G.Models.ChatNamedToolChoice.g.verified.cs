//HintName: G.Models.ChatNamedToolChoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Named tool choice for specific function
    /// </summary>
    public sealed partial class ChatNamedToolChoice
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ChatNamedToolChoiceTypeJsonConverter))]
        public global::G.ChatNamedToolChoiceType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("function", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ChatNamedToolChoiceFunction Function { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatNamedToolChoice" /> class.
        /// </summary>
        /// <param name="function"></param>
        /// <param name="type"></param>
        public ChatNamedToolChoice(
            global::G.ChatNamedToolChoiceFunction function,
            global::G.ChatNamedToolChoiceType type)
        {
            this.Type = type;
            this.Function = function ?? throw new global::System.ArgumentNullException(nameof(function));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatNamedToolChoice" /> class.
        /// </summary>
        public ChatNamedToolChoice()
        {
        }
    }
}