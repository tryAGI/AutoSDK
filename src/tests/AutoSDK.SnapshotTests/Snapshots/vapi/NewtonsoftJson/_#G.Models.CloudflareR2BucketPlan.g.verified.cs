//HintName: G.Models.CloudflareR2BucketPlan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CloudflareR2BucketPlan
    {
        /// <summary>
        /// Cloudflare R2 Access key ID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("accessKeyId")]
        public string? AccessKeyId { get; set; }

        /// <summary>
        /// Cloudflare R2 access key secret. This is not returned in the API.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("secretAccessKey")]
        public string? SecretAccessKey { get; set; }

        /// <summary>
        /// Cloudflare R2 base url.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// This is the name of the bucket.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// This is the path where call artifacts will be stored.<br/>
        /// Usage:<br/>
        /// - To store call artifacts in a specific folder, set this to the full path. Eg. "/folder-name1/folder-name2".<br/>
        /// - To store call artifacts in the root of the bucket, leave this blank.<br/>
        /// @default "/"
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("path")]
        public string? Path { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudflareR2BucketPlan" /> class.
        /// </summary>
        /// <param name="name">
        /// This is the name of the bucket.
        /// </param>
        /// <param name="accessKeyId">
        /// Cloudflare R2 Access key ID.
        /// </param>
        /// <param name="secretAccessKey">
        /// Cloudflare R2 access key secret. This is not returned in the API.
        /// </param>
        /// <param name="url">
        /// Cloudflare R2 base url.
        /// </param>
        /// <param name="path">
        /// This is the path where call artifacts will be stored.<br/>
        /// Usage:<br/>
        /// - To store call artifacts in a specific folder, set this to the full path. Eg. "/folder-name1/folder-name2".<br/>
        /// - To store call artifacts in the root of the bucket, leave this blank.<br/>
        /// @default "/"
        /// </param>
        public CloudflareR2BucketPlan(
            string name,
            string? accessKeyId,
            string? secretAccessKey,
            string? url,
            string? path)
        {
            this.AccessKeyId = accessKeyId;
            this.SecretAccessKey = secretAccessKey;
            this.Url = url;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Path = path;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudflareR2BucketPlan" /> class.
        /// </summary>
        public CloudflareR2BucketPlan()
        {
        }
    }
}