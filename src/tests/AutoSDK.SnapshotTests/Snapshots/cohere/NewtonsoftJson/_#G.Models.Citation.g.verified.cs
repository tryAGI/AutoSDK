//HintName: G.Models.Citation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Citation information containing sources and the text cited.
    /// </summary>
    public sealed partial class Citation
    {
        /// <summary>
        /// Start index of the cited snippet in the original source text.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start")]
        public int? Start { get; set; }

        /// <summary>
        /// End index of the cited snippet in the original source text.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end")]
        public int? End { get; set; }

        /// <summary>
        /// Text snippet that is being cited.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sources")]
        public global::System.Collections.Generic.IList<global::G.Source>? Sources { get; set; }

        /// <summary>
        /// The type of citation which indicates what part of the response the citation is for.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.CitationType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Citation" /> class.
        /// </summary>
        /// <param name="start">
        /// Start index of the cited snippet in the original source text.
        /// </param>
        /// <param name="end">
        /// End index of the cited snippet in the original source text.
        /// </param>
        /// <param name="text">
        /// Text snippet that is being cited.
        /// </param>
        /// <param name="sources"></param>
        /// <param name="type">
        /// The type of citation which indicates what part of the response the citation is for.
        /// </param>
        public Citation(
            int? start,
            int? end,
            string? text,
            global::System.Collections.Generic.IList<global::G.Source>? sources,
            global::G.CitationType? type)
        {
            this.Start = start;
            this.End = end;
            this.Text = text;
            this.Sources = sources;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Citation" /> class.
        /// </summary>
        public Citation()
        {
        }
    }
}