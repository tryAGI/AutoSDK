//HintName: G.Models.FilesStatsRes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FilesStatsRes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_size_bytes", Required = global::Newtonsoft.Json.Required.Always)]
        public long TotalSizeBytes { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FilesStatsRes" /> class.
        /// </summary>
        /// <param name="totalSizeBytes"></param>
        public FilesStatsRes(
            long totalSizeBytes)
        {
            this.TotalSizeBytes = totalSizeBytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilesStatsRes" /> class.
        /// </summary>
        public FilesStatsRes()
        {
        }
    }
}