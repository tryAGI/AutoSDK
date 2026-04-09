//HintName: G.Models.OpenAIResponsesRefusalContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAIResponsesRefusalContent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.OpenAiResponsesRefusalContentTypeJsonConverter))]
        public global::G.OpenAiResponsesRefusalContentType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("refusal", Required = global::Newtonsoft.Json.Required.Always)]
        public string Refusal { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIResponsesRefusalContent" /> class.
        /// </summary>
        /// <param name="refusal"></param>
        /// <param name="type"></param>
        public OpenAIResponsesRefusalContent(
            string refusal,
            global::G.OpenAiResponsesRefusalContentType type)
        {
            this.Type = type;
            this.Refusal = refusal ?? throw new global::System.ArgumentNullException(nameof(refusal));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIResponsesRefusalContent" /> class.
        /// </summary>
        public OpenAIResponsesRefusalContent()
        {
        }
    }
}