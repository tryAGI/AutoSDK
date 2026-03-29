//HintName: G.Models.ExtractV2JobMetadata2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Job-level metadata.
    /// </summary>
    public sealed partial class ExtractV2JobMetadata2
    {
        /// <summary>
        /// Usage metrics
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::G.ExtractJobUsage? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractV2JobMetadata2" /> class.
        /// </summary>
        /// <param name="usage">
        /// Usage metrics
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtractV2JobMetadata2(
            global::G.ExtractJobUsage? usage)
        {
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractV2JobMetadata2" /> class.
        /// </summary>
        public ExtractV2JobMetadata2()
        {
        }
    }
}