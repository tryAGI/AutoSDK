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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OpenAiResponsesRefusalContentTypeJsonConverter))]
        public global::G.OpenAiResponsesRefusalContentType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refusal")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Refusal { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIResponsesRefusalContent" /> class.
        /// </summary>
        /// <param name="refusal"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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