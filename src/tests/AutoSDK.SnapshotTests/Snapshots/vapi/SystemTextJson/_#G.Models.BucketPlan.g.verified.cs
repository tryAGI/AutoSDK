//HintName: G.Models.BucketPlan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BucketPlan
    {
        /// <summary>
        /// This is the name of the bucket.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// This is the region of the bucket.<br/>
        /// Usage:<br/>
        /// - If `credential.type` is `aws`, then this is required.<br/>
        /// - If `credential.type` is `gcp`, then this is optional since GCP allows buckets to be accessed without a region but region is required for data residency requirements. Read here: https://cloud.google.com/storage/docs/request-endpoints<br/>
        /// This overrides the `credential.region` field if it is provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        public string? Region { get; set; }

        /// <summary>
        /// This is the path where call artifacts will be stored.<br/>
        /// Usage:<br/>
        /// - To store call artifacts in a specific folder, set this to the full path. Eg. "/folder-name1/folder-name2".<br/>
        /// - To store call artifacts in the root of the bucket, leave this blank.<br/>
        /// @default "/"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// This is the HMAC access key offered by GCP for interoperability with S3 clients. Here is the guide on how to create: https://cloud.google.com/storage/docs/authentication/managing-hmackeys#console<br/>
        /// Usage:<br/>
        /// - If `credential.type` is `gcp`, then this is required.<br/>
        /// - If `credential.type` is `aws`, then this is not required since credential.awsAccessKeyId is used instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hmacAccessKey")]
        public string? HmacAccessKey { get; set; }

        /// <summary>
        /// This is the secret for the HMAC access key. Here is the guide on how to create: https://cloud.google.com/storage/docs/authentication/managing-hmackeys#console<br/>
        /// Usage:<br/>
        /// - If `credential.type` is `gcp`, then this is required.<br/>
        /// - If `credential.type` is `aws`, then this is not required since credential.awsSecretAccessKey is used instead.<br/>
        /// Note: This is not returned in the API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hmacSecret")]
        public string? HmacSecret { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BucketPlan" /> class.
        /// </summary>
        /// <param name="name">
        /// This is the name of the bucket.
        /// </param>
        /// <param name="region">
        /// This is the region of the bucket.<br/>
        /// Usage:<br/>
        /// - If `credential.type` is `aws`, then this is required.<br/>
        /// - If `credential.type` is `gcp`, then this is optional since GCP allows buckets to be accessed without a region but region is required for data residency requirements. Read here: https://cloud.google.com/storage/docs/request-endpoints<br/>
        /// This overrides the `credential.region` field if it is provided.
        /// </param>
        /// <param name="path">
        /// This is the path where call artifacts will be stored.<br/>
        /// Usage:<br/>
        /// - To store call artifacts in a specific folder, set this to the full path. Eg. "/folder-name1/folder-name2".<br/>
        /// - To store call artifacts in the root of the bucket, leave this blank.<br/>
        /// @default "/"
        /// </param>
        /// <param name="hmacAccessKey">
        /// This is the HMAC access key offered by GCP for interoperability with S3 clients. Here is the guide on how to create: https://cloud.google.com/storage/docs/authentication/managing-hmackeys#console<br/>
        /// Usage:<br/>
        /// - If `credential.type` is `gcp`, then this is required.<br/>
        /// - If `credential.type` is `aws`, then this is not required since credential.awsAccessKeyId is used instead.
        /// </param>
        /// <param name="hmacSecret">
        /// This is the secret for the HMAC access key. Here is the guide on how to create: https://cloud.google.com/storage/docs/authentication/managing-hmackeys#console<br/>
        /// Usage:<br/>
        /// - If `credential.type` is `gcp`, then this is required.<br/>
        /// - If `credential.type` is `aws`, then this is not required since credential.awsSecretAccessKey is used instead.<br/>
        /// Note: This is not returned in the API.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BucketPlan(
            string name,
            string? region,
            string? path,
            string? hmacAccessKey,
            string? hmacSecret)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Region = region;
            this.Path = path;
            this.HmacAccessKey = hmacAccessKey;
            this.HmacSecret = hmacSecret;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BucketPlan" /> class.
        /// </summary>
        public BucketPlan()
        {
        }
    }
}