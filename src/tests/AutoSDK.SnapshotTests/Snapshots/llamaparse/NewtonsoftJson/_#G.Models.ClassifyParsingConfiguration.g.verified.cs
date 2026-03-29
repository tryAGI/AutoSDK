//HintName: G.Models.ClassifyParsingConfiguration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parsing configuration for a classify job.
    /// </summary>
    public sealed partial class ClassifyParsingConfiguration
    {
        /// <summary>
        /// The language to parse the files in<br/>
        /// Default Value: en
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lang")]
        public global::G.ParserLanguages? Lang { get; set; }

        /// <summary>
        /// The maximum number of pages to parse<br/>
        /// Default Value: 5
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_pages")]
        public int? MaxPages { get; set; }

        /// <summary>
        /// The pages to target for parsing (0-indexed, so first page is at 0)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target_pages")]
        public global::System.Collections.Generic.IList<int>? TargetPages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifyParsingConfiguration" /> class.
        /// </summary>
        /// <param name="lang">
        /// The language to parse the files in<br/>
        /// Default Value: en
        /// </param>
        /// <param name="maxPages">
        /// The maximum number of pages to parse<br/>
        /// Default Value: 5
        /// </param>
        /// <param name="targetPages">
        /// The pages to target for parsing (0-indexed, so first page is at 0)
        /// </param>
        public ClassifyParsingConfiguration(
            global::G.ParserLanguages? lang,
            int? maxPages,
            global::System.Collections.Generic.IList<int>? targetPages)
        {
            this.Lang = lang;
            this.MaxPages = maxPages;
            this.TargetPages = targetPages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifyParsingConfiguration" /> class.
        /// </summary>
        public ClassifyParsingConfiguration()
        {
        }
    }
}