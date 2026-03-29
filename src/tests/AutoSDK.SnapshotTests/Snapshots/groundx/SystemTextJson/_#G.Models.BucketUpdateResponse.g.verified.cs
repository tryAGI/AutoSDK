//HintName: G.Models.BucketUpdateResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BucketUpdateResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucket")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.BucketUpdateDetail Bucket { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BucketUpdateResponse" /> class.
        /// </summary>
        /// <param name="bucket"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BucketUpdateResponse(
            global::G.BucketUpdateDetail bucket)
        {
            this.Bucket = bucket ?? throw new global::System.ArgumentNullException(nameof(bucket));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BucketUpdateResponse" /> class.
        /// </summary>
        public BucketUpdateResponse()
        {
        }
    }
}