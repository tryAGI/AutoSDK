//HintName: G.Models.ChatCompletionResponseMessageAnnotation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A URL citation when using web search.
    /// </summary>
    public sealed partial class ChatCompletionResponseMessageAnnotation
    {
        /// <summary>
        /// The type of the URL citation. Always `url_citation`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChatCompletionResponseMessageAnnotationTypeJsonConverter))]
        public global::G.ChatCompletionResponseMessageAnnotationType Type { get; set; }

        /// <summary>
        /// A URL citation when using web search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url_citation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ChatCompletionResponseMessageAnnotationUrlCitation UrlCitation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionResponseMessageAnnotation" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the URL citation. Always `url_citation`.
        /// </param>
        /// <param name="urlCitation">
        /// A URL citation when using web search.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionResponseMessageAnnotation(
            global::G.ChatCompletionResponseMessageAnnotationUrlCitation urlCitation,
            global::G.ChatCompletionResponseMessageAnnotationType type)
        {
            this.UrlCitation = urlCitation ?? throw new global::System.ArgumentNullException(nameof(urlCitation));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionResponseMessageAnnotation" /> class.
        /// </summary>
        public ChatCompletionResponseMessageAnnotation()
        {
        }
    }
}