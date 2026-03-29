//HintName: G.Models.CachedContentUsageMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Metadata on the usage of the cached content.
    /// </summary>
    public sealed partial class CachedContentUsageMetadata
    {
        /// <summary>
        /// Total number of tokens that the cached content consumes.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("totalTokenCount")]
        public int? TotalTokenCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CachedContentUsageMetadata" /> class.
        /// </summary>
        /// <param name="totalTokenCount">
        /// Total number of tokens that the cached content consumes.
        /// </param>
        public CachedContentUsageMetadata(
            int? totalTokenCount)
        {
            this.TotalTokenCount = totalTokenCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CachedContentUsageMetadata" /> class.
        /// </summary>
        public CachedContentUsageMetadata()
        {
        }
    }
}