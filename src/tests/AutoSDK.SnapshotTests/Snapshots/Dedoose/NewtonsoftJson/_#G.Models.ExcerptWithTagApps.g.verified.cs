//HintName: G.Models.ExcerptWithTagApps.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExcerptWithTagApps
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("excerptData")]
        public global::G.Excerpt? ExcerptData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tagApps")]
        public global::System.Collections.Generic.IList<global::G.TagAppDTO>? TagApps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExcerptWithTagApps" /> class.
        /// </summary>
        /// <param name="excerptData"></param>
        /// <param name="tagApps"></param>
        public ExcerptWithTagApps(
            global::G.Excerpt? excerptData,
            global::System.Collections.Generic.IList<global::G.TagAppDTO>? tagApps)
        {
            this.ExcerptData = excerptData;
            this.TagApps = tagApps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExcerptWithTagApps" /> class.
        /// </summary>
        public ExcerptWithTagApps()
        {
        }
    }
}