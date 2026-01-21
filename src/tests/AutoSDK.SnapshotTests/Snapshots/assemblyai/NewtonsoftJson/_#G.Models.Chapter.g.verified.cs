//HintName: G.Models.Chapter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Chapter of the audio file<br/>
    /// Example: {"summary":"Smoke from hundreds of wildfires in Canada is triggering air quality alerts throughout the US. Skylines from Maine to Maryland to Minnesota are gray and smoggy. In some places, the air quality warnings include the warning to stay inside.","gist":"Smoggy air quality alerts across US","headline":"Smoke from hundreds of wildfires in Canada is triggering air quality alerts across US","start":250,"end":28840}
    /// </summary>
    public sealed partial class Chapter
    {
        /// <summary>
        /// An ultra-short summary (just a few words) of the content spoken in the chapter
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gist", Required = global::Newtonsoft.Json.Required.Always)]
        public string Gist { get; set; } = default!;

        /// <summary>
        /// A single sentence summary of the content spoken during the chapter
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("headline", Required = global::Newtonsoft.Json.Required.Always)]
        public string Headline { get; set; } = default!;

        /// <summary>
        /// A one paragraph summary of the content spoken during the chapter
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary", Required = global::Newtonsoft.Json.Required.Always)]
        public string Summary { get; set; } = default!;

        /// <summary>
        /// The starting time, in milliseconds, for the chapter
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start", Required = global::Newtonsoft.Json.Required.Always)]
        public int Start { get; set; } = default!;

        /// <summary>
        /// The starting time, in milliseconds, for the chapter
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end", Required = global::Newtonsoft.Json.Required.Always)]
        public int End { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Chapter" /> class.
        /// </summary>
        /// <param name="gist">
        /// An ultra-short summary (just a few words) of the content spoken in the chapter
        /// </param>
        /// <param name="headline">
        /// A single sentence summary of the content spoken during the chapter
        /// </param>
        /// <param name="summary">
        /// A one paragraph summary of the content spoken during the chapter
        /// </param>
        /// <param name="start">
        /// The starting time, in milliseconds, for the chapter
        /// </param>
        /// <param name="end">
        /// The starting time, in milliseconds, for the chapter
        /// </param>
        public Chapter(
            string gist,
            string headline,
            string summary,
            int start,
            int end)
        {
            this.Gist = gist ?? throw new global::System.ArgumentNullException(nameof(gist));
            this.Headline = headline ?? throw new global::System.ArgumentNullException(nameof(headline));
            this.Summary = summary ?? throw new global::System.ArgumentNullException(nameof(summary));
            this.Start = start;
            this.End = end;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Chapter" /> class.
        /// </summary>
        public Chapter()
        {
        }
    }
}