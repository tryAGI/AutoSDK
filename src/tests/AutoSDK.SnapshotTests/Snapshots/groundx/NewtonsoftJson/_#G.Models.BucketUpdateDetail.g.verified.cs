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
        [global::Newtonsoft.Json.JsonProperty("bucketId", Required = global::Newtonsoft.Json.Required.Always)]
        public int BucketId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BucketUpdateDetail" /> class.
        /// </summary>
        /// <param name="bucketId"></param>
        /// <param name="name"></param>
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