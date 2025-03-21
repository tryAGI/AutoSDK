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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ChatCompletionResponseMessageAnnotationType Type { get; set; }

        /// <summary>
        /// A URL citation when using web search.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url_citation", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ChatCompletionResponseMessageAnnotationUrlCitation UrlCitation { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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