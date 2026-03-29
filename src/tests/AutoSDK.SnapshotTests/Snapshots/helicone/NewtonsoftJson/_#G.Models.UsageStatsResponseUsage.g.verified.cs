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
        [global::Newtonsoft.Json.JsonProperty("totalGB", Required = global::Newtonsoft.Json.Required.Always)]
        public double TotalGB { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("totalBytes", Required = global::Newtonsoft.Json.Required.Always)]
        public double TotalBytes { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("totalRequests", Required = global::Newtonsoft.Json.Required.Always)]
        public double TotalRequests { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageStatsResponseUsage" /> class.
        /// </summary>
        /// <param name="totalGB"></param>
        /// <param name="totalBytes"></param>
        /// <param name="totalRequests"></param>
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