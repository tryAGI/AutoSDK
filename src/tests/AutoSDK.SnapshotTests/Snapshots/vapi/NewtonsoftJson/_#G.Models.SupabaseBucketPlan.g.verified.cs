//HintName: G.Models.SupabaseBucketPlan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SupabaseBucketPlan
    {
        /// <summary>
        /// This is the S3 Region. It should look like us-east-1<br/>
        /// It should be one of the supabase regions defined in the SUPABASE_REGION enum<br/>
        /// Check https://supabase.com/docs/guides/platform/regions for up to date regions
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("region", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SupabaseBucketPlanRegionJsonConverter))]
        public global::G.SupabaseBucketPlanRegion Region { get; set; } = default!;

        /// <summary>
        /// This is the S3 compatible URL for Supabase S3<br/>
        /// This should look like https://&lt;project-ID&gt;.supabase.co/storage/v1/s3
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// This is the Supabase S3 Access Key ID.<br/>
        /// The user creates this in the Supabase project Storage settings
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("accessKeyId", Required = global::Newtonsoft.Json.Required.Always)]
        public string AccessKeyId { get; set; } = default!;

        /// <summary>
        /// This is the Supabase S3 Secret Access Key.<br/>
        /// The user creates this in the Supabase project Storage settings along with the access key id
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("secretAccessKey", Required = global::Newtonsoft.Json.Required.Always)]
        public string SecretAccessKey { get; set; } = default!;

        /// <summary>
        /// This is the Supabase S3 Bucket Name.<br/>
        /// The user must create this in Supabase under Storage &gt; Buckets<br/>
        /// A bucket that does not exist will not be checked now, but file uploads will fail
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// This is the Supabase S3 Bucket Folder Path.<br/>
        /// The user can create this in Supabase under Storage &gt; Buckets<br/>
        /// A path that does not exist will not be checked now, but file uploads will fail<br/>
        /// A Path is like a folder in the bucket<br/>
        /// Eg. If the bucket is called "my-bucket" and the path is "my-folder", the full path is "my-bucket/my-folder"
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("path")]
        public string? Path { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SupabaseBucketPlan" /> class.
        /// </summary>
        /// <param name="region">
        /// This is the S3 Region. It should look like us-east-1<br/>
        /// It should be one of the supabase regions defined in the SUPABASE_REGION enum<br/>
        /// Check https://supabase.com/docs/guides/platform/regions for up to date regions
        /// </param>
        /// <param name="url">
        /// This is the S3 compatible URL for Supabase S3<br/>
        /// This should look like https://&lt;project-ID&gt;.supabase.co/storage/v1/s3
        /// </param>
        /// <param name="accessKeyId">
        /// This is the Supabase S3 Access Key ID.<br/>
        /// The user creates this in the Supabase project Storage settings
        /// </param>
        /// <param name="secretAccessKey">
        /// This is the Supabase S3 Secret Access Key.<br/>
        /// The user creates this in the Supabase project Storage settings along with the access key id
        /// </param>
        /// <param name="name">
        /// This is the Supabase S3 Bucket Name.<br/>
        /// The user must create this in Supabase under Storage &gt; Buckets<br/>
        /// A bucket that does not exist will not be checked now, but file uploads will fail
        /// </param>
        /// <param name="path">
        /// This is the Supabase S3 Bucket Folder Path.<br/>
        /// The user can create this in Supabase under Storage &gt; Buckets<br/>
        /// A path that does not exist will not be checked now, but file uploads will fail<br/>
        /// A Path is like a folder in the bucket<br/>
        /// Eg. If the bucket is called "my-bucket" and the path is "my-folder", the full path is "my-bucket/my-folder"
        /// </param>
        public SupabaseBucketPlan(
            global::G.SupabaseBucketPlanRegion region,
            string url,
            string accessKeyId,
            string secretAccessKey,
            string name,
            string? path)
        {
            this.Region = region;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.AccessKeyId = accessKeyId ?? throw new global::System.ArgumentNullException(nameof(accessKeyId));
            this.SecretAccessKey = secretAccessKey ?? throw new global::System.ArgumentNullException(nameof(secretAccessKey));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Path = path;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SupabaseBucketPlan" /> class.
        /// </summary>
        public SupabaseBucketPlan()
        {
        }
    }
}