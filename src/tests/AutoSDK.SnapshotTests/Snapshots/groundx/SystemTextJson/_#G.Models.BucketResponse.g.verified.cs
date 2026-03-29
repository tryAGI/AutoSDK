//HintName: G.Models.BucketResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BucketResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucket")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.BucketDetail Bucket { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BucketResponse" /> class.
        /// </summary>
        /// <param name="bucket"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BucketResponse(
            global::G.BucketDetail bucket)
        {
            this.Bucket = bucket ?? throw new global::System.ArgumentNullException(nameof(bucket));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BucketResponse" /> class.
        /// </summary>
        public BucketResponse()
        {
        }
    }
}