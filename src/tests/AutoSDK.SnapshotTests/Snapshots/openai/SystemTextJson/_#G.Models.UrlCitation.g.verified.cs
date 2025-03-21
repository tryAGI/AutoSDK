//HintName: G.Models.UrlCitation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A citation for a web resource used to generate a model response.
    /// </summary>
    public sealed partial class UrlCitation
    {
        /// <summary>
        /// The index of the last character of the URL citation in the message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EndIndex { get; set; }

        /// <summary>
        /// The index of the first character of the URL citation in the message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartIndex { get; set; }

        /// <summary>
        /// The title of the web resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// The type of the URL citation. Always `url_citation`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UrlCitationTypeJsonConverter))]
        public global::G.UrlCitationType Type { get; set; }

        /// <summary>
        /// The URL of the web resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UrlCitation" /> class.
        /// </summary>
        /// <param name="endIndex">
        /// The index of the last character of the URL citation in the message.
        /// </param>
        /// <param name="startIndex">
        /// The index of the first character of the URL citation in the message.
        /// </param>
        /// <param name="title">
        /// The title of the web resource.
        /// </param>
        /// <param name="type">
        /// The type of the URL citation. Always `url_citation`.
        /// </param>
        /// <param name="url">
        /// The URL of the web resource.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UrlCitation(
            int endIndex,
            int startIndex,
            string title,
            string url,
            global::G.UrlCitationType type)
        {
            this.EndIndex = endIndex;
            this.StartIndex = startIndex;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UrlCitation" /> class.
        /// </summary>
        public UrlCitation()
        {
        }
    }
}