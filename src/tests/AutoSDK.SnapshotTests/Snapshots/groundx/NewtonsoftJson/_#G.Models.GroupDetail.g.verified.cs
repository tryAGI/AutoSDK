//HintName: G.Models.GroupDetail.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GroupDetail
    {
        /// <summary>
        /// The content buckets associated with the group
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("buckets")]
        public global::System.Collections.Generic.IList<global::G.BucketDetail>? Buckets { get; set; }

        /// <summary>
        /// The data time when the group was created, in RFC3339 format<br/>
        /// Example: 2023-10-03T08:59:39.312Z
        /// </summary>
        /// <example>2023-10-03T08:59:39.312Z</example>
        [global::Newtonsoft.Json.JsonProperty("created")]
        public global::System.DateTime? Created { get; set; }

        /// <summary>
        /// The number of files contained in the content buckets associated with the group
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fileCount")]
        public int? FileCount { get; set; }

        /// <summary>
        /// The total file size of files contained in the content buckets associated with the group<br/>
        /// Example: 3.1GB
        /// </summary>
        /// <example>3.1GB</example>
        [global::Newtonsoft.Json.JsonProperty("fileSize")]
        public string? FileSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("groupId", Required = global::Newtonsoft.Json.Required.Always)]
        public int GroupId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The data time when the group was last updated, in RFC3339 format<br/>
        /// Example: 2023-10-03T08:59:39.312Z
        /// </summary>
        /// <example>2023-10-03T08:59:39.312Z</example>
        [global::Newtonsoft.Json.JsonProperty("updated")]
        public global::System.DateTime? Updated { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupDetail" /> class.
        /// </summary>
        /// <param name="groupId"></param>
        /// <param name="buckets">
        /// The content buckets associated with the group
        /// </param>
        /// <param name="created">
        /// The data time when the group was created, in RFC3339 format<br/>
        /// Example: 2023-10-03T08:59:39.312Z
        /// </param>
        /// <param name="fileCount">
        /// The number of files contained in the content buckets associated with the group
        /// </param>
        /// <param name="fileSize">
        /// The total file size of files contained in the content buckets associated with the group<br/>
        /// Example: 3.1GB
        /// </param>
        /// <param name="name"></param>
        /// <param name="updated">
        /// The data time when the group was last updated, in RFC3339 format<br/>
        /// Example: 2023-10-03T08:59:39.312Z
        /// </param>
        public GroupDetail(
            int groupId,
            global::System.Collections.Generic.IList<global::G.BucketDetail>? buckets,
            global::System.DateTime? created,
            int? fileCount,
            string? fileSize,
            string? name,
            global::System.DateTime? updated)
        {
            this.Buckets = buckets;
            this.Created = created;
            this.FileCount = fileCount;
            this.FileSize = fileSize;
            this.GroupId = groupId;
            this.Name = name;
            this.Updated = updated;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupDetail" /> class.
        /// </summary>
        public GroupDetail()
        {
        }
    }
}