//HintName: G.Models.OutputConfigSrtOverrides.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parameters that override default values of srt conversion. max_line_length: sets maximum count of characters per subtitle line including white space. max_lines: sets maximum count of lines in a subtitle section.
    /// </summary>
    public sealed partial class OutputConfigSrtOverrides
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_line_length")]
        public int? MaxLineLength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_lines")]
        public int? MaxLines { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputConfigSrtOverrides" /> class.
        /// </summary>
        /// <param name="maxLineLength"></param>
        /// <param name="maxLines"></param>
        public OutputConfigSrtOverrides(
            int? maxLineLength,
            int? maxLines)
        {
            this.MaxLineLength = maxLineLength;
            this.MaxLines = maxLines;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputConfigSrtOverrides" /> class.
        /// </summary>
        public OutputConfigSrtOverrides()
        {
        }
    }
}