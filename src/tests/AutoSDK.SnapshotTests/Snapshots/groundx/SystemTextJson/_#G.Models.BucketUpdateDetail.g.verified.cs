//HintName: G.Models.BucketUpdateDetail.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BucketUpdateDetail
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucketId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int BucketId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BucketUpdateDetail" /> class.
        /// </summary>
        /// <param name="bucketId"></param>
        /// <param name="name"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BucketUpdateDetail(
            int bucketId,
            string? name)
        {
            this.BucketId = bucketId;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BucketUpdateDetail" /> class.
        /// </summary>
        public BucketUpdateDetail()
        {
        }
    }
}