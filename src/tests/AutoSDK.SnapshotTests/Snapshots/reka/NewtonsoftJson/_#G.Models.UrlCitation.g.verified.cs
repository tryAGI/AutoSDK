//HintName: G.Models.UrlCitation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// URL citation details with character-level positioning in the response content.
    /// </summary>
    public sealed partial class UrlCitation
    {
        /// <summary>
        /// The web resource URL.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Title of the cited resource.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// Character position in content where the citation starts.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int StartIndex { get; set; } = default!;

        /// <summary>
        /// Character position in content where the citation ends.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int EndIndex { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UrlCitation" /> class.
        /// </summary>
        /// <param name="url">
        /// The web resource URL.
        /// </param>
        /// <param name="title">
        /// Title of the cited resource.
        /// </param>
        /// <param name="startIndex">
        /// Character position in content where the citation starts.
        /// </param>
        /// <param name="endIndex">
        /// Character position in content where the citation ends.
        /// </param>
        public UrlCitation(
            string url,
            string title,
            int startIndex,
            int endIndex)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.StartIndex = startIndex;
            this.EndIndex = endIndex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UrlCitation" /> class.
        /// </summary>
        public UrlCitation()
        {
        }
    }
}