//HintName: G.Models.OutputConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OutputConfig
    {
        /// <summary>
        /// Parameters that override default values of srt conversion. max_line_length: sets maximum count of characters per subtitle line including white space. max_lines: sets maximum count of lines in a subtitle section.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("srt_overrides")]
        public global::G.OutputConfigSrtOverrides? SrtOverrides { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputConfig" /> class.
        /// </summary>
        /// <param name="srtOverrides">
        /// Parameters that override default values of srt conversion. max_line_length: sets maximum count of characters per subtitle line including white space. max_lines: sets maximum count of lines in a subtitle section.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputConfig(
            global::G.OutputConfigSrtOverrides? srtOverrides)
        {
            this.SrtOverrides = srtOverrides;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputConfig" /> class.
        /// </summary>
        public OutputConfig()
        {
        }
    }
}