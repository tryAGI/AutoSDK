//HintName: G.Models.UpdateS3CredentialDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateS3CredentialDTO
    {
        /// <summary>
        /// AWS access key ID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("awsAccessKeyId")]
        public string? AwsAccessKeyId { get; set; }

        /// <summary>
        /// AWS access key secret. This is not returned in the API.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("awsSecretAccessKey")]
        public string? AwsSecretAccessKey { get; set; }

        /// <summary>
        /// AWS region in which the S3 bucket is located.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("region")]
        public string? Region { get; set; }

        /// <summary>
        /// AWS S3 bucket name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("s3BucketName")]
        public string? S3BucketName { get; set; }

        /// <summary>
        /// The path prefix for the uploaded recording. Ex. "recordings/"
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("s3PathPrefix")]
        public string? S3PathPrefix { get; set; }

        /// <summary>
        /// This is the order in which this storage provider is tried during upload retries. Lower numbers are tried first in increasing order.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fallbackIndex")]
        public double? FallbackIndex { get; set; }

        /// <summary>
        /// This is the name of credential. This is just for your reference.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateS3CredentialDTO" /> class.
        /// </summary>
        /// <param name="awsAccessKeyId">
        /// AWS access key ID.
        /// </param>
        /// <param name="awsSecretAccessKey">
        /// AWS access key secret. This is not returned in the API.
        /// </param>
        /// <param name="region">
        /// AWS region in which the S3 bucket is located.
        /// </param>
        /// <param name="s3BucketName">
        /// AWS S3 bucket name.
        /// </param>
        /// <param name="s3PathPrefix">
        /// The path prefix for the uploaded recording. Ex. "recordings/"
        /// </param>
        /// <param name="fallbackIndex">
        /// This is the order in which this storage provider is tried during upload retries. Lower numbers are tried first in increasing order.
        /// </param>
        /// <param name="name">
        /// This is the name of credential. This is just for your reference.
        /// </param>
        public UpdateS3CredentialDTO(
            string? awsAccessKeyId,
            string? awsSecretAccessKey,
            string? region,
            string? s3BucketName,
            string? s3PathPrefix,
            double? fallbackIndex,
            string? name)
        {
            this.AwsAccessKeyId = awsAccessKeyId;
            this.AwsSecretAccessKey = awsSecretAccessKey;
            this.Region = region;
            this.S3BucketName = s3BucketName;
            this.S3PathPrefix = s3PathPrefix;
            this.FallbackIndex = fallbackIndex;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateS3CredentialDTO" /> class.
        /// </summary>
        public UpdateS3CredentialDTO()
        {
        }
    }
}