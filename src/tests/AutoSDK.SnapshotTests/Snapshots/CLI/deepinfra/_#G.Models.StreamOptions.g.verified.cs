//HintName: G.Models.StreamOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StreamOptions
    {
        /// <summary>
        /// whether to include usage data<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_usage")]
        public bool? IncludeUsage { get; set; }

        /// <summary>
        /// whether to include usage stats continuously with each streaming event<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("continuous_usage_stats")]
        public bool? ContinuousUsageStats { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamOptions" /> class.
        /// </summary>
        /// <param name="includeUsage">
        /// whether to include usage data<br/>
        /// Default Value: true
        /// </param>
        /// <param name="continuousUsageStats">
        /// whether to include usage stats continuously with each streaming event<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StreamOptions(
            bool? includeUsage,
            bool? continuousUsageStats)
        {
            this.IncludeUsage = includeUsage;
            this.ContinuousUsageStats = continuousUsageStats;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamOptions" /> class.
        /// </summary>
        public StreamOptions()
        {
        }
    }
}