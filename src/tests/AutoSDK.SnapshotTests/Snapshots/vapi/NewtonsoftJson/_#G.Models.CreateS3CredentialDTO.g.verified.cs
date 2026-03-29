//HintName: G.Models.CreateS3CredentialDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateS3CredentialDTO
    {
        /// <summary>
        /// Credential provider. Only allowed value is s3
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        public global::G.CreateS3CredentialDTOProvider Provider { get; set; }

        /// <summary>
        /// AWS access key ID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("awsAccessKeyId", Required = global::Newtonsoft.Json.Required.Always)]
        public string AwsAccessKeyId { get; set; } = default!;

        /// <summary>
        /// AWS access key secret. This is not returned in the API.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("awsSecretAccessKey", Required = global::Newtonsoft.Json.Required.Always)]
        public string AwsSecretAccessKey { get; set; } = default!;

        /// <summary>
        /// AWS region in which the S3 bucket is located.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("region", Required = global::Newtonsoft.Json.Required.Always)]
        public string Region { get; set; } = default!;

        /// <summary>
        /// AWS S3 bucket name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("s3BucketName", Required = global::Newtonsoft.Json.Required.Always)]
        public string S3BucketName { get; set; } = default!;

        /// <summary>
        /// The path prefix for the uploaded recording. Ex. "recordings/"
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("s3PathPrefix", Required = global::Newtonsoft.Json.Required.Always)]
        public string S3PathPrefix { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="CreateS3CredentialDTO" /> class.
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
        /// <param name="provider">
        /// Credential provider. Only allowed value is s3
        /// </param>
        /// <param name="fallbackIndex">
        /// This is the order in which this storage provider is tried during upload retries. Lower numbers are tried first in increasing order.
        /// </param>
        /// <param name="name">
        /// This is the name of credential. This is just for your reference.
        /// </param>
        public CreateS3CredentialDTO(
            string awsAccessKeyId,
            string awsSecretAccessKey,
            string region,
            string s3BucketName,
            string s3PathPrefix,
            global::G.CreateS3CredentialDTOProvider provider,
            double? fallbackIndex,
            string? name)
        {
            this.Provider = provider;
            this.AwsAccessKeyId = awsAccessKeyId ?? throw new global::System.ArgumentNullException(nameof(awsAccessKeyId));
            this.AwsSecretAccessKey = awsSecretAccessKey ?? throw new global::System.ArgumentNullException(nameof(awsSecretAccessKey));
            this.Region = region ?? throw new global::System.ArgumentNullException(nameof(region));
            this.S3BucketName = s3BucketName ?? throw new global::System.ArgumentNullException(nameof(s3BucketName));
            this.S3PathPrefix = s3PathPrefix ?? throw new global::System.ArgumentNullException(nameof(s3PathPrefix));
            this.FallbackIndex = fallbackIndex;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateS3CredentialDTO" /> class.
        /// </summary>
        public CreateS3CredentialDTO()
        {
        }
    }
}