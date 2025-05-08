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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.UrlCitationBodyType Type { get; set; } = global::G.UrlCitationBodyType.UrlCitation;

        /// <summary>
        /// The URL of the web resource.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// The index of the first character of the URL citation in the message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int StartIndex { get; set; } = default!;

        /// <summary>
        /// The index of the last character of the URL citation in the message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int EndIndex { get; set; } = default!;

        /// <summary>
        /// The title of the web resource.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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