//HintName: G.Models.GroupCreateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GroupCreateRequest
    {
        /// <summary>
        /// The name of the group being created.<br/>
        /// Example: your_group_name
        /// </summary>
        /// <example>your_group_name</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Specify bucketName to automatically create a bucket, by the name specified, and add it to the created group.<br/>
        /// Example: your_new_bucket_name
        /// </summary>
        /// <example>your_new_bucket_name</example>
        [global::Newtonsoft.Json.JsonProperty("bucketName")]
        public string? BucketName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupCreateRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the group being created.<br/>
        /// Example: your_group_name
        /// </param>
        /// <param name="bucketName">
        /// Specify bucketName to automatically create a bucket, by the name specified, and add it to the created group.<br/>
        /// Example: your_new_bucket_name
        /// </param>
        public GroupCreateRequest(
            string name,
            string? bucketName)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.BucketName = bucketName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupCreateRequest" /> class.
        /// </summary>
        public GroupCreateRequest()
        {
        }
    }
}