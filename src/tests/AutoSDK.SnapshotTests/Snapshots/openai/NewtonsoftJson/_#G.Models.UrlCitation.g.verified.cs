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
        [global::Newtonsoft.Json.JsonProperty("end_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int EndIndex { get; set; } = default!;

        /// <summary>
        /// The index of the first character of the URL citation in the message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int StartIndex { get; set; } = default!;

        /// <summary>
        /// The title of the web resource.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// The type of the URL citation. Always `url_citation`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.UrlCitationType Type { get; set; }

        /// <summary>
        /// The URL of the web resource.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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