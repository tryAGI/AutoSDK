//HintName: G.Models.UrlCitationBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A citation for a web resource used to generate a model response.
    /// </summary>
    public sealed partial class UrlCitationBody
    {
        /// <summary>
        /// The type of the URL citation. Always `url_citation`.<br/>
        /// Default Value: url_citation
        /// </summary>
        /// <default>global::G.UrlCitationBodyType.UrlCitation</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UrlCitationBodyTypeJsonConverter))]
        public global::G.UrlCitationBodyType Type { get; set; } = global::G.UrlCitationBodyType.UrlCitation;

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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartIndex { get; set; }

        /// <summary>
        /// The index of the last character of the URL citation in the message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EndIndex { get; set; }

        /// <summary>
        /// The title of the web resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UrlCitationBody" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the URL citation. Always `url_citation`.<br/>
        /// Default Value: url_citation
        /// </param>
        /// <param name="url">
        /// The URL of the web resource.
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
        public UrlCitationBody(
            string url,
            int startIndex,
            int endIndex,
            string title,
            global::G.UrlCitationBodyType type = global::G.UrlCitationBodyType.UrlCitation)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.StartIndex = startIndex;
            this.EndIndex = endIndex;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UrlCitationBody" /> class.
        /// </summary>
        public UrlCitationBody()
        {
        }
    }
}