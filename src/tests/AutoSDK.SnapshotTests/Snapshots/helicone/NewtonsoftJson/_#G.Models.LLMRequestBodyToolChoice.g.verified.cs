//HintName: G.Models.LLMRequestBodyToolChoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LLMRequestBodyToolChoice
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.LLMRequestBodyToolChoiceTypeJsonConverter))]
        public global::G.LLMRequestBodyToolChoiceType Type { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMRequestBodyToolChoice" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="name"></param>
        public LLMRequestBodyToolChoice(
            global::G.LLMRequestBodyToolChoiceType type,
            string? name)
        {
            this.Name = name;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMRequestBodyToolChoice" /> class.
        /// </summary>
        public LLMRequestBodyToolChoice()
        {
        }
    }
}