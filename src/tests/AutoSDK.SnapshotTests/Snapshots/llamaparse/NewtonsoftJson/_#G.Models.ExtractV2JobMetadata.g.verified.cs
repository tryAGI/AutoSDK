//HintName: G.Models.ExtractV2JobMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Job-level metadata.
    /// </summary>
    public sealed partial class ExtractV2JobMetadata
    {
        /// <summary>
        /// Usage metrics
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage")]
        public global::G.ExtractJobUsage? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractV2JobMetadata" /> class.
        /// </summary>
        /// <param name="usage">
        /// Usage metrics
        /// </param>
        public ExtractV2JobMetadata(
            global::G.ExtractJobUsage? usage)
        {
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractV2JobMetadata" /> class.
        /// </summary>
        public ExtractV2JobMetadata()
        {
        }

    }
}