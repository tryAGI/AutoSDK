//HintName: G.Models.ChatCompletionMessageAnnotation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A URL citation when using web search.
    /// </summary>
    public sealed partial class ChatCompletionMessageAnnotation
    {
        /// <summary>
        /// The type of the URL citation. Always `url_citation`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChatCompletionMessageAnnotationTypeJsonConverter))]
        public global::G.ChatCompletionMessageAnnotationType Type { get; set; }

        /// <summary>
        /// A URL citation when using web search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url_citation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ChatCompletionMessageAnnotationURLCitation UrlCitation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionMessageAnnotation" /> class.
        /// </summary>
        /// <param name="urlCitation">
        /// A URL citation when using web search.
        /// </param>
        /// <param name="type">
        /// The type of the URL citation. Always `url_citation`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionMessageAnnotation(
            global::G.ChatCompletionMessageAnnotationURLCitation urlCitation,
            global::G.ChatCompletionMessageAnnotationType type)
        {
            this.Type = type;
            this.UrlCitation = urlCitation ?? throw new global::System.ArgumentNullException(nameof(urlCitation));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionMessageAnnotation" /> class.
        /// </summary>
        public ChatCompletionMessageAnnotation()
        {
        }
    }
}