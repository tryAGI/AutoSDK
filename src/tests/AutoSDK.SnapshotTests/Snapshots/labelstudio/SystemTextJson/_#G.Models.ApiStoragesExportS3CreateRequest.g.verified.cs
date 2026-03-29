//HintName: G.Models.ApiStoragesExportS3CreateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiStoragesExportS3CreateRequest
    {
        /// <summary>
        /// AWS_ACCESS_KEY_ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_access_key_id")]
        public string? AwsAccessKeyId { get; set; }

        /// <summary>
        /// AWS_SECRET_ACCESS_KEY
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_secret_access_key")]
        public string? AwsSecretAccessKey { get; set; }

        /// <summary>
        /// AWS_SESSION_TOKEN
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_session_token")]
        public string? AwsSessionToken { get; set; }

        /// <summary>
        /// AWS SSE KMS Key ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_sse_kms_key_id")]
        public string? AwsSseKmsKeyId { get; set; }

        /// <summary>
        /// S3 bucket name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucket")]
        public string? Bucket { get; set; }

        /// <summary>
        /// Deletion from storage enabled.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_delete_objects")]
        public bool? CanDeleteObjects { get; set; }

        /// <summary>
        /// Storage description
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// S3 bucket prefix
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefix")]
        public string? Prefix { get; set; }

        /// <summary>
        /// Project ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        public int? Project { get; set; }

        /// <summary>
        /// AWS Region
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region_name")]
        public string? RegionName { get; set; }

        /// <summary>
        /// S3 Endpoint
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("s3_endpoint")]
        public string? S3Endpoint { get; set; }

        /// <summary>
        /// Storage title
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiStoragesExportS3CreateRequest" /> class.
        /// </summary>
        /// <param name="awsAccessKeyId">
        /// AWS_ACCESS_KEY_ID
        /// </param>
        /// <param name="awsSecretAccessKey">
        /// AWS_SECRET_ACCESS_KEY
        /// </param>
        /// <param name="awsSessionToken">
        /// AWS_SESSION_TOKEN
        /// </param>
        /// <param name="awsSseKmsKeyId">
        /// AWS SSE KMS Key ID
        /// </param>
        /// <param name="bucket">
        /// S3 bucket name
        /// </param>
        /// <param name="canDeleteObjects">
        /// Deletion from storage enabled.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="description">
        /// Storage description
        /// </param>
        /// <param name="prefix">
        /// S3 bucket prefix
        /// </param>
        /// <param name="project">
        /// Project ID
        /// </param>
        /// <param name="regionName">
        /// AWS Region
        /// </param>
        /// <param name="s3Endpoint">
        /// S3 Endpoint
        /// </param>
        /// <param name="title">
        /// Storage title
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiStoragesExportS3CreateRequest(
            string? awsAccessKeyId,
            string? awsSecretAccessKey,
            string? awsSessionToken,
            string? awsSseKmsKeyId,
            string? bucket,
            bool? canDeleteObjects,
            string? description,
            string? prefix,
            int? project,
            string? regionName,
            string? s3Endpoint,
            string? title)
        {
            this.AwsAccessKeyId = awsAccessKeyId;
            this.AwsSecretAccessKey = awsSecretAccessKey;
            this.AwsSessionToken = awsSessionToken;
            this.AwsSseKmsKeyId = awsSseKmsKeyId;
            this.Bucket = bucket;
            this.CanDeleteObjects = canDeleteObjects;
            this.Description = description;
            this.Prefix = prefix;
            this.Project = project;
            this.RegionName = regionName;
            this.S3Endpoint = s3Endpoint;
            this.Title = title;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiStoragesExportS3CreateRequest" /> class.
        /// </summary>
        public ApiStoragesExportS3CreateRequest()
        {
        }
    }
}