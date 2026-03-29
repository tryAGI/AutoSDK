//HintName: G.Models.LlamaParseTimeouts.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Job timeout configuration.<br/>
    /// Total timeout = base_in_seconds + (extra_time_per_page_in_seconds × page_count).<br/>
    /// Use these settings for large documents or complex parsing that needs more time.
    /// </summary>
    public sealed partial class LlamaParseTimeouts
    {
        /// <summary>
        /// Base timeout for the job in seconds (max 1800 = 30 minutes). This is the minimum time allowed regardless of document size
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_in_seconds")]
        public int? BaseInSeconds { get; set; }

        /// <summary>
        /// Additional timeout per page in seconds (max 300 = 5 minutes). Total timeout = base + (this value × page count)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extra_time_per_page_in_seconds")]
        public int? ExtraTimePerPageInSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LlamaParseTimeouts" /> class.
        /// </summary>
        /// <param name="baseInSeconds">
        /// Base timeout for the job in seconds (max 1800 = 30 minutes). This is the minimum time allowed regardless of document size
        /// </param>
        /// <param name="extraTimePerPageInSeconds">
        /// Additional timeout per page in seconds (max 300 = 5 minutes). Total timeout = base + (this value × page count)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LlamaParseTimeouts(
            int? baseInSeconds,
            int? extraTimePerPageInSeconds)
        {
            this.BaseInSeconds = baseInSeconds;
            this.ExtraTimePerPageInSeconds = extraTimePerPageInSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LlamaParseTimeouts" /> class.
        /// </summary>
        public LlamaParseTimeouts()
        {
        }
    }
}