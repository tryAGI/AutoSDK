//HintName: G.Models.ResponseUrlCitation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A citation for a web resource.
    /// </summary>
    public sealed partial class ResponseUrlCitation
    {
        /// <summary>
        /// The type of the annotation. Always `url_citation`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseUrlCitationTypeJsonConverter))]
        public global::G.ResponseUrlCitationType Type { get; set; }

        /// <summary>
        /// The URL of the web resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// The index of the first character of the URL citation in the message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_index")]
        public int? StartIndex { get; set; }

        /// <summary>
        /// The index of the last character of the URL citation in the message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_index")]
        public int? EndIndex { get; set; }

        /// <summary>
        /// The title of the web resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseUrlCitation" /> class.
        /// </summary>
        /// <param name="url">
        /// The URL of the web resource.
        /// </param>
        /// <param name="type">
        /// The type of the annotation. Always `url_citation`.
        /// </param>
        /// <param name="startIndex">
        /// The index of the first character of the URL citation in the message.
        /// </param>
        /// <param name="endIndex">
        /// The index of the last character of the URL citation in the message.
        /// </param>
        /// <param name="title">
        /// The title of the web resource.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseUrlCitation(
            string url,
            global::G.ResponseUrlCitationType type,
            int? startIndex,
            int? endIndex,
            string? title)
        {
            this.Type = type;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.StartIndex = startIndex;
            this.EndIndex = endIndex;
            this.Title = title;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseUrlCitation" /> class.
        /// </summary>
        public ResponseUrlCitation()
        {
        }
    }
}