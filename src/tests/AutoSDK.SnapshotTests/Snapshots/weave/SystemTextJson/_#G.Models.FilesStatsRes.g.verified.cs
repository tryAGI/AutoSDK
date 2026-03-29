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
        [global::System.Text.Json.Serialization.JsonPropertyName("total_size_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long TotalSizeBytes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FilesStatsRes" /> class.
        /// </summary>
        /// <param name="totalSizeBytes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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