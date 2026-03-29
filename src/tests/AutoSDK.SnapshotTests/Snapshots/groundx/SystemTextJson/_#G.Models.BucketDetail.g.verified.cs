//HintName: G.Models.BucketDetail.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BucketDetail
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucketId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int BucketId { get; set; }

        /// <summary>
        /// The data time when the bucket was created, in RFC3339 format<br/>
        /// Example: 2023-10-03T08:59:39.312Z
        /// </summary>
        /// <example>2023-10-03T08:59:39.312Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public global::System.DateTime? Created { get; set; }

        /// <summary>
        /// The number of files contained in the content bucket
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileCount")]
        public int? FileCount { get; set; }

        /// <summary>
        /// The total file size of files contained in the content bucket<br/>
        /// Example: 3.1GB
        /// </summary>
        /// <example>3.1GB</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileSize")]
        public string? FileSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The data time when the bucket was last updated, in RFC3339 format<br/>
        /// Example: 2023-10-03T08:59:39.312Z
        /// </summary>
        /// <example>2023-10-03T08:59:39.312Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated")]
        public global::System.DateTime? Updated { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BucketDetail" /> class.
        /// </summary>
        /// <param name="bucketId"></param>
        /// <param name="created">
        /// The data time when the bucket was created, in RFC3339 format<br/>
        /// Example: 2023-10-03T08:59:39.312Z
        /// </param>
        /// <param name="fileCount">
        /// The number of files contained in the content bucket
        /// </param>
        /// <param name="fileSize">
        /// The total file size of files contained in the content bucket<br/>
        /// Example: 3.1GB
        /// </param>
        /// <param name="name"></param>
        /// <param name="updated">
        /// The data time when the bucket was last updated, in RFC3339 format<br/>
        /// Example: 2023-10-03T08:59:39.312Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BucketDetail(
            int bucketId,
            global::System.DateTime? created,
            int? fileCount,
            string? fileSize,
            string? name,
            global::System.DateTime? updated)
        {
            this.BucketId = bucketId;
            this.Created = created;
            this.FileCount = fileCount;
            this.FileSize = fileSize;
            this.Name = name;
            this.Updated = updated;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BucketDetail" /> class.
        /// </summary>
        public BucketDetail()
        {
        }
    }
}