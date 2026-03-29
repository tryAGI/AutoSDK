//HintName: G.Models.BucketListResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BucketListResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buckets")]
        public global::System.Collections.Generic.IList<global::G.BucketDetail>? Buckets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BucketListResponse" /> class.
        /// </summary>
        /// <param name="buckets"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BucketListResponse(
            global::System.Collections.Generic.IList<global::G.BucketDetail>? buckets)
        {
            this.Buckets = buckets;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BucketListResponse" /> class.
        /// </summary>
        public BucketListResponse()
        {
        }
    }
}