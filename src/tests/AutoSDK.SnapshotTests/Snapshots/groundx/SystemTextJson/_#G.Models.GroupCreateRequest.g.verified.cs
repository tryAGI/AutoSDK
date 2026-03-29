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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Specify bucketName to automatically create a bucket, by the name specified, and add it to the created group.<br/>
        /// Example: your_new_bucket_name
        /// </summary>
        /// <example>your_new_bucket_name</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucketName")]
        public string? BucketName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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