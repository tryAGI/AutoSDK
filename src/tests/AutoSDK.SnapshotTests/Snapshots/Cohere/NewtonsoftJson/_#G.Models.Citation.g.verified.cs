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
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start")]
        public int? Start { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end")]
        public int? End { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sources")]
        public global::System.Collections.Generic.IList<global::G.Source>? Sources { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Citation" /> class.
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="text"></param>
        /// <param name="sources"></param>
        public Citation(
            int? start,
            int? end,
            string? text,
            global::System.Collections.Generic.IList<global::G.Source>? sources)
        {
            this.Start = start;
            this.End = end;
            this.Text = text;
            this.Sources = sources;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Citation" /> class.
        /// </summary>
        public Citation()
        {
        }
    }
}