//HintName: G.Models.UsageStatsResponseUsage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsageStatsResponseUsage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalGB")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalGB { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalBytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalBytes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalRequests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalRequests { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageStatsResponseUsage" /> class.
        /// </summary>
        /// <param name="totalGB"></param>
        /// <param name="totalBytes"></param>
        /// <param name="totalRequests"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageStatsResponseUsage(
            double totalGB,
            double totalBytes,
            double totalRequests)
        {
            this.TotalGB = totalGB;
            this.TotalBytes = totalBytes;
            this.TotalRequests = totalRequests;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageStatsResponseUsage" /> class.
        /// </summary>
        public UsageStatsResponseUsage()
        {
        }
    }
}