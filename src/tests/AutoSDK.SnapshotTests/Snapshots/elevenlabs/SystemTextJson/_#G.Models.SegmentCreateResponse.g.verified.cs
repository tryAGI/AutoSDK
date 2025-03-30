//HintName: G.Models.SegmentCreateResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SegmentCreateResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_segment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NewSegment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentCreateResponse" /> class.
        /// </summary>
        /// <param name="version"></param>
        /// <param name="newSegment"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SegmentCreateResponse(
            int version,
            string newSegment)
        {
            this.Version = version;
            this.NewSegment = newSegment ?? throw new global::System.ArgumentNullException(nameof(newSegment));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentCreateResponse" /> class.
        /// </summary>
        public SegmentCreateResponse()
        {
        }
    }
}