//HintName: G.Models.S3Credential.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class S3Credential
    {
        /// <summary>
        /// Credential provider. Only allowed value is s3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.S3CredentialProviderJsonConverter))]
        public global::G.S3CredentialProvider Provider { get; set; }

        /// <summary>
        /// AWS access key ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("awsAccessKeyId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AwsAccessKeyId { get; set; }

        /// <summary>
        /// AWS access key secret. This is not returned in the API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("awsSecretAccessKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AwsSecretAccessKey { get; set; }

        /// <summary>
        /// AWS region in which the S3 bucket is located.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Region { get; set; }

        /// <summary>
        /// AWS S3 bucket name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("s3BucketName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string S3BucketName { get; set; }

        /// <summary>
        /// The path prefix for the uploaded recording. Ex. "recordings/"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("s3PathPrefix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string S3PathPrefix { get; set; }

        /// <summary>
        /// This is the order in which this storage provider is tried during upload retries. Lower numbers are tried first in increasing order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallbackIndex")]
        public double? FallbackIndex { get; set; }

        /// <summary>
        /// This is the unique identifier for the credential.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// This is the unique identifier for the org that this credential belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrgId { get; set; }

        /// <summary>
        /// This is the ISO 8601 date-time string of when the credential was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// This is the ISO 8601 date-time string of when the assistant was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// This is the name of credential. This is just for your reference.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="S3Credential" /> class.
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
        /// <param name="id">
        /// This is the unique identifier for the credential.
        /// </param>
        /// <param name="orgId">
        /// This is the unique identifier for the org that this credential belongs to.
        /// </param>
        /// <param name="createdAt">
        /// This is the ISO 8601 date-time string of when the credential was created.
        /// </param>
        /// <param name="updatedAt">
        /// This is the ISO 8601 date-time string of when the assistant was last updated.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public S3Credential(
            string awsAccessKeyId,
            string awsSecretAccessKey,
            string region,
            string s3BucketName,
            string s3PathPrefix,
            string id,
            string orgId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::G.S3CredentialProvider provider,
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
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OrgId = orgId ?? throw new global::System.ArgumentNullException(nameof(orgId));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="S3Credential" /> class.
        /// </summary>
        public S3Credential()
        {
        }
    }
}