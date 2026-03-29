//HintName: G.Models.PageSegmentationConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PageSegmentationConfig
    {
        /// <summary>
        /// Default Value: page
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mode")]
        public string? Mode { get; set; }

        /// <summary>
        /// Default Value: <br/>
        /// ---
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page_separator")]
        public string? PageSeparator { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PageSegmentationConfig" /> class.
        /// </summary>
        /// <param name="mode">
        /// Default Value: page
        /// </param>
        /// <param name="pageSeparator">
        /// Default Value: <br/>
        /// ---
        /// </param>
        public PageSegmentationConfig(
            string? mode,
            string? pageSeparator)
        {
            this.Mode = mode;
            this.PageSeparator = pageSeparator;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PageSegmentationConfig" /> class.
        /// </summary>
        public PageSegmentationConfig()
        {
        }
    }
}